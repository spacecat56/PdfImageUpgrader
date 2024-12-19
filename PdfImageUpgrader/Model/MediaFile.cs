using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PdfImageUpgrader.Model
{
    internal class MediaFile(FileInfo f)
    {
        public static Regex SeqNoRex = new Regex(@".*?image(?<nbr>\d+)[.].+");
        public FileInfo TheFile { get; set; } = f;
        public int SortNo { get; private set; }
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

        public MediaFile Init()
        {
            var m = SeqNoRex.Match(TheFile.Name);
            if (m.Success)
                SortNo = int.Parse(m.Groups["nbr"].Value);

            return this;
        }

        public float Aspect()
        {
            GetSize();
            if (theSize == null) return 0;
            return (float)theSize.Value.Width / theSize.Value.Height;
        }
    }

    internal class MediaFiles : List<MediaFile>
    {
        public MediaFiles(DirectoryInfo mediaDir)
        {
            List<MediaFile> medias = mediaDir.EnumerateFiles()
                .Where(f => MediaUpgradeProject.AnyMediaRex.IsMatch(f.Name))
                .Select(o => new MediaFile(o).Init())
                .OrderBy(f => f.SortNo).ToList();
            AddRange(medias);
        }
    }
}
