using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfImageUpgrader.Model
{
    internal class ImageComparator
    {
        public float MatchCutoff { get; set; } = 0.1f;


        public (bool, float) Compare(string path1, string path2)
        {
            throw new NotImplementedException();
        }
    }
}
