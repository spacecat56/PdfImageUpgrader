using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace PdfImageUpgrader.Model
{
    public class MediaUpgradeProject
    {
        public string InputDocx { get; set; }
        public string InputPdf { get; set; }
        public string MediaDir { get; set; }
        public string OutputPdf { get; set; }
        public bool Valid { get; private set; }
        public bool DeleteEmptyTransparency { get; set; } // not implemented yet


        public DocxWrangler DocxWrangler { get; private set; }
        public MediaFiles MediaFiles { get; private set; }
        public PdfWrangler PdfWrangler { get; private set; }

        public static Regex DocxMediaRex = new Regex(".*?word/media/.*?[.](jpg|jpeg|png)");
        public static Regex AnyMediaRex = new Regex(".*?[.](jpg|jpeg|png)");

        public string ExtractFromDocx()
        {
            DocxWrangler = new DocxWrangler() { InputPath = InputDocx, MediaPath = MediaDir };
            int r = DocxWrangler.ExtractMediaFiles();

            MediaFiles = new MediaFiles(new DirectoryInfo(MediaDir));

            return $"{r} media files extracted from {Path.GetFileName(InputDocx)}";
        }

        public string InitPdf()
        {
            PdfWrangler = new PdfWrangler()
            {
                InputPdf = InputPdf,
                OutputPdf = OutputPdf,
                MediaDir = MediaDir,
                Comparator = new ImageComparator(), // defaults, with potential to be exposed and configured externally
                DeleteEmptyTransparency = DeleteEmptyTransparency
            };

            int c = PdfWrangler.LocateImages();
            StringBuilder rvs = new StringBuilder();
            rvs.AppendLine($"{c} images found in pdf");

            (bool rvb, rvs) = PdfWrangler.VerifyImages(MediaFiles, rvs);
            Valid = rvb;

            return rvs.ToString();
        }

        public string UpgradePdf()
        {
            StringBuilder rvs = new StringBuilder();
            PdfWrangler.OutputPdf = OutputPdf;
            (int ri, rvs) = PdfWrangler.UpgradeImages(MediaFiles, rvs);
            return rvs.ToString();
        }

    }
}
