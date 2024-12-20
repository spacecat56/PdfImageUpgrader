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
    public class PdfWrangler
    {
        public string InputPdf { get; set; }
        public string OutputPdf { get; set; }
        public string MediaDir { get; set; }
        public ImageComparator Comparator { get; set; }

        public List<PdfImage> Images { get; } = [];
        public StringBuilder DiagnosticInfo { get; set; } = new();
        public int LocateImages()
        {
            Images.Clear();
            DiagnosticInfo.Clear();

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(InputPdf));
            Rectangle pageSize;
            PdfCanvas canvas;
            
            int n = pdfDoc.GetNumberOfPages();
            
            DiagnosticInfo.AppendLine($"***Begin Info for {Path.GetFileName(InputPdf)}; {n} pages");

            for (int i = 1; i <= n; i++)
            {
                PdfPage page = pdfDoc.GetPage(i);
                PdfDictionary pageDict = page.GetPdfObject();
                PdfDictionary resources = pageDict.GetAsDictionary(PdfName.Resources);
                PdfDictionary xObjects = resources.GetAsDictionary(PdfName.XObject);
                if (xObjects == null)
                    continue;
                DiagnosticInfo.AppendLine($"....page {i}");
                int ix = 0;
                foreach (PdfName xObject in xObjects.KeySet())
                {
                    ix++;
                    PdfStream stream = xObjects.GetAsStream(xObject);
                    PdfImageXObject img = new PdfImageXObject(stream);

                    int pxCount = (int)(img.GetWidth() * img.GetHeight());
                    if (pxCount < PdfImage.MinPixels)
                    {
                        DiagnosticInfo.AppendLine($".......skip image {ix}, {pxCount:F0}px, {xObject.GetValue()}");
                        continue;
                    }

                    string mediaFileName = $"p{i:0000}-{ix}_{xObject.GetValue()}.{FileExtensionFor(img.IdentifyImageType())}";
                    string mPath = Path.Combine(MediaDir, mediaFileName);
                    byte[] imgbytes = img.GetImageBytes();
                    using (FileStream fso = new FileStream(mPath, FileMode.Create, FileAccess.Write))
                    {
                        fso.Write(imgbytes);
                    }

                    Images.Add(new PdfImage()
                    {
                        Page = i,
                        SeqNbr = Images.Count + 1,
                        Name = xObject.GetValue(),
                        Width = img.GetWidth(),
                        Height = img.GetHeight(),
                        IndexOnPage = ix,
                        ImageFilePath = mPath
                    });
                    DiagnosticInfo.AppendLine($"........{Images.Count}. {xObject.GetValue()}. w={img.GetWidth()}, h={img.GetHeight()}; type={img.IdentifyImageType()}; file={mediaFileName}");
                }
            }
            pdfDoc.Close();


            return Images.Count;
        }

        private string FileExtensionFor(ImageType it)
        {
            switch (it)
            {
                case ImageType.JPEG:
                    return "jpg";
                    break;
                case ImageType.PNG:
                    return "png";
                    break;
                case ImageType.GIF:
                    return "gif";
                    break;
                case ImageType.BMP:
                    return "bmp";
                    break;
                case ImageType.TIFF:
                    return "tif";
                    break;
                //case ImageType.WMF:
                //    break;
                //case ImageType.PS:
                //    break;
                case ImageType.JPEG2000:
                    return "jp2";
                    break;
                //case ImageType.JBIG2:
                //    break;
                //case ImageType.RAW:
                //    break;
                //case ImageType.NONE:
                //    break;
                default:
                    return "unk";
            }
        }


        public (bool, StringBuilder) VerifyImages(MediaFiles medias, StringBuilder rvs)
        {
            bool rvb = false;
            rvs ??= new StringBuilder();

            int ixPdfImage = 0;
            for (int i = 0; i < medias.Count; i++)
            {
                MediaFile mf = medias[i];
                mf.Target = null;
                mf.OkToApply = false;
                rvs.AppendLine($"Media file {mf.Name} {mf.GetSize().Width:0.0}x{mf.GetSize().Height:0.0} AR {mf.Aspect()}");

                while (ixPdfImage < Images.Count)
                {
                    PdfImage pim = Images[ixPdfImage];
                    float rel = mf.GetSize().Width / pim.Width;
                    (bool isMatch, double delta) = Comparator.Compare(pim.ImageFilePath, mf.TheFile.FullName);
                    if (!isMatch)
                    {
                        ixPdfImage++;
                        continue;
                    }
                    mf.Target = pim;
                    mf.ImageMetric = delta;
                    rvb = mf.OkToApply = true; // any found == ok
                    rvs.AppendLine($"\tPDF image p. {pim.Page}, {pim.Name} {pim.Width:0.0}x{pim.Height:0.0} AR {pim.Aspect}: Upgrade res: {rel:0.##}");
                    ixPdfImage++;
                    break;
                }

                if (!mf.OkToApply)
                {
                    rvs.AppendLine($"\tNo match in pdf");
                    rvb = mf.OkToApply = false;
                }

            }

            return (rvb, rvs);
        }

        public (int, StringBuilder) UpgradeImages(MediaFiles medias, StringBuilder rvs)
        {
            int upg = 0;
            rvs ??= new StringBuilder();

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(InputPdf), new PdfWriter(OutputPdf));

            for (int i = 0; i < medias.Count; i++)
            {
                MediaFile mf = medias[i];
                rvs.AppendLine($"Media file {mf.Name}; {mf.GetSize().Width:0.0}x{mf.GetSize().Height:0.0} AR {mf.Aspect()}");

                bool goodToGo = mf.OkToApply && mf.Target != null;
                if (!goodToGo)
                {
                    rvs.AppendLine("...skipped");
                    continue;
                }

                PdfImage pim = mf.Target; //Images[i];
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

    public class PdfImage
    {
        public static int MinPixels = 1000;

        public int Page { get; set; }
        public int SeqNbr { get; set; }
        public int IndexOnPage { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }
        public string ImageFilePath { get; set; }
        public string ImageFileName => ImageFilePath == null ? "" : Path.GetFileName(ImageFilePath);

        public float Aspect => Height == 0 ? 0 : Width / Height;
        //public byte ObjectType { get; set; }
    }
}
