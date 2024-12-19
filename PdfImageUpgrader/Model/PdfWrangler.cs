using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf;
using Rectangle = iText.Kernel.Geom.Rectangle;
using Document = iText.Layout.Document;
using Image = iText.Layout.Element.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf.Xobject;
using static iText.Kernel.Pdf.Colorspace.PdfDeviceCs;
using iText.IO.Image;

namespace PdfImageUpgrader.Model
{
    internal class PdfWrangler
    {
        public string InputPdf { get; set; }
        public string OutputPdf { get; set; }

        public List<PdfImage> Images { get; } = [];

        public int LocateImages()
        {
            Images.Clear();

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(InputPdf));
            //Document document = new Document(pdfDoc);
            Rectangle pageSize;
            PdfCanvas canvas;
            int n = pdfDoc.GetNumberOfPages();
            for (int i = 1; i <= n; i++)
            {
                PdfPage page = pdfDoc.GetPage(i);
                PdfDictionary pageDict = page.GetPdfObject();
                PdfDictionary resources = pageDict.GetAsDictionary(PdfName.Resources);
                PdfDictionary xObjects = resources.GetAsDictionary(PdfName.XObject);
                if (xObjects == null)
                    continue;
                int ix = 0;
                foreach (PdfName xObject in xObjects.KeySet())
                {
                    //if (xObject.GetObjectType() != 9)
                    //    continue;
                    ix++;
                    PdfStream stream = xObjects.GetAsStream(xObject);
                    PdfImageXObject img = new PdfImageXObject(stream);

                    Images.Add(new PdfImage()
                    {
                        Page = i, 
                        SeqNbr = Images.Count+1,
                        Name = xObject.GetValue(),
                        Width = img.GetWidth(),
                        Height = img.GetHeight(),
                        IndexOnPage = ix
                        //ObjectType = xObject.GetObjectType()
                    });
                }
                //PdfName imgRef = xObjects.KeySet().First();
                //pageSize = page.GetPageSize();
                //canvas = new PdfCanvas(page);
                ////Draw header text
            }
            pdfDoc.Close();


            return Images.Count;
        }


        public (bool, StringBuilder) VerifyImages(MediaFiles medias, StringBuilder rvs)
        {
            bool rvb = true;
            rvs ??= new StringBuilder();

            for (int i = 0; i < medias.Count; i++)
            {
                MediaFile mf = medias[i];
                rvs.AppendLine($"Media file {mf.Name} {mf.GetSize().Width:0.0}x{mf.GetSize().Height:0.0} AR {mf.Aspect()}");
                if (i + 1 > Images.Count)
                {
                    rvs.AppendLine($"\tNo match in pdf");
                    rvb = false;
                    continue;
                }

                PdfImage pim = Images[i];
                float rel = mf.GetSize().Width / pim.Width;
                bool goodAr = Math.Abs(mf.Aspect() - pim.Aspect) < 0.002f;
                rvb &= goodAr;
                rvs.AppendLine($"\tPDF image p. {pim.Page}, {pim.Name} {pim.Width:0.0}x{pim.Height:0.0} AR {pim.Aspect}: match: {goodAr}; Upgrade res: {rel:0.##}");
            }

            return (rvb, rvs);
        }

        public (int, StringBuilder) UpgradeImages(MediaFiles medias, StringBuilder rvs)
        {
            int upg = 0;
            rvs ??= new StringBuilder();

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(InputPdf), new PdfWriter(OutputPdf));
            //int n = pdfDoc.GetNumberOfPages();

            for (int i = 0; i < medias.Count; i++)
            {
                MediaFile mf = medias[i];
                rvs.AppendLine($"Media file {mf.Name} {mf.GetSize().Width:0.0}x{mf.GetSize().Height:0.0} AR {mf.Aspect()}");
                if (i + 1 > Images.Count)
                {
                    rvs.AppendLine($"\tNo match in pdf");
                    continue;
                }


                PdfImage pim = Images[i];
                PdfPage page = pdfDoc.GetPage(pim.Page);
                PdfDictionary pageDict = page.GetPdfObject();
                PdfDictionary resources = pageDict.GetAsDictionary(PdfName.Resources);
                PdfDictionary xObjects = resources.GetAsDictionary(PdfName.XObject);
                PdfName imgRef = xObjects.KeySet().ElementAt(pim.IndexOnPage-1);

                ImageData imd = ImageDataFactory.Create(mf.TheFile.FullName);
                Image img = new Image(imd);
                PdfStream stream = xObjects.GetAsStream(imgRef);
                xObjects.Put(imgRef, img.GetXObject().GetPdfObject());


                float rel = mf.GetSize().Width / pim.Width;
                bool goodAr = Math.Abs(mf.Aspect() - pim.Aspect) < 0.002f;
                upg++;
                rvs.AppendLine($"\tPDF image p. {pim.Page}, {pim.Name} Replaced; Upgrade res by {rel:0.##} times");
            }

            pdfDoc.Close();

            return (upg, rvs);

        }


    }

    internal class PdfImage
    {
        public int Page { get; set; }
        public int SeqNbr { get; set; }
        public int IndexOnPage { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }

        public float Aspect => Height == 0 ? 0 : Width / Height;
        //public byte ObjectType { get; set; }
    }
}
