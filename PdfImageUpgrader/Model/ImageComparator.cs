using ImageMagick;

namespace PdfImageUpgrader.Model
{
    public class ImageComparator
    {
        public double MatchCutoff { get; set; } = 0.1;
        public ErrorMetric Metric { get; set; } = ErrorMetric.Fuzz;

        public (bool, double) Compare(string smallerFile, string largerFile)
        {
            MagickImage mig1 = new MagickImage(smallerFile);
            MagickImage mig2 = new MagickImage(largerFile);
            mig2.Resize(mig1.Width, mig1.Height);
            double sim = mig1.Compare(mig2, Metric);
            return (sim <= MatchCutoff, sim);
        }
    }
}
