using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfImageUpgrader.Model
{
    internal class MediaFile(FileInfo f)
    {
        public FileInfo TheFile { get; set; } = f;
        public string Name => TheFile.Name;
        private Size? theSize;
        public Size GetSize()
        {
            if (theSize != null)
                return theSize.Value;
            using var fileStream = new FileStream(TheFile.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
            using var image = Image.FromStream(fileStream, false, false);
            int h = image.Height;
            int w = image.Width;
            theSize = new Size(w, h);
            return theSize.Value;
        }
    }

    internal class MediaFiles : List<MediaFile>
    {
        public MediaFiles(DirectoryInfo mediaDir)
        {

        }
    }
}
