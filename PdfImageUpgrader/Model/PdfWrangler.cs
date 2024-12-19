using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf;
using Rectangle = iText.Kernel.Geom.Rectangle;
using Document = iText.Layout.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf.Xobject;

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
                foreach (PdfName xObject in xObjects.KeySet())
                {
                    //if (xObject.GetObjectType() != 9)
                    //    continue;
                    PdfStream stream = xObjects.GetAsStream(xObject);
                    PdfImageXObject img = new PdfImageXObject(stream);

                    Images.Add(new PdfImage()
                    {
                        Page = i, 
                        SeqNbr = Images.Count+1,
                        Name = xObject.GetValue(),
                        Width = img.GetWidth(),
                        Height = img.GetHeight()
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

    }

    internal class PdfImage
    {
        public int Page { get; set; }
        public int SeqNbr { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }
        //public byte ObjectType { get; set; }
    }
}
