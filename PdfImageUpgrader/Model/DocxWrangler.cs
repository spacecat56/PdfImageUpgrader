using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PdfImageUpgrader.Model
{
    internal class DocxWrangler
    {
        public string InputPath { get; set; }
        public string MediaPath { get; set; }
        //public List<> Type { get; set; }
        public int ExtractMediaFiles()
        {
            int rv = 0;
            Directory.CreateDirectory(MediaPath);

            using ZipArchive archive = ZipFile.OpenRead(InputPath);
            foreach (ZipArchiveEntry entry in archive.Entries)
            {
                if (!MediaUpgradeProject.DocxMediaRex.IsMatch(entry.FullName)) continue;
                string destinationPath = Path.GetFullPath(Path.Combine(MediaPath, entry.Name));
                entry.ExtractToFile(destinationPath, true);
                rv++;
            }


            return rv;
        }
    }
}
