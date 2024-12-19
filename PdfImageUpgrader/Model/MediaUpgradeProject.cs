using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfImageUpgrader.Model
{
    internal class MediaUpgradeProject
    {
        public string InputDocx { get; set; }
        public string InputPdf { get; set; }
        public string MediaDir { get; set; }
        public string OutputPdf { get; set; }

        public DocxWrangler DocxWrangler { get; private set; }
        public MediaFiles MediaFiles { get; private set; }

        public string ExtractFromDocx()
        {
            DocxWrangler = new DocxWrangler() { InputPath = InputDocx, MediaPath = MediaDir };
            int r = DocxWrangler.ExtractMediaFiles();

            return $"{r} media files extracted from {InputDocx} to directory {MediaDir}";
        }

    }
}
