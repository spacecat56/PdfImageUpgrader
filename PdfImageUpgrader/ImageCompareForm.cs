using PdfImageUpgrader.Model;

namespace PdfImageUpgrader
{
    public partial class ImageCompareForm : Form
    {
        public MediaFiles MediaFiles { get; set; }
        public int MediaIx { get; set; }
        public ImageCompareForm()
        {
            InitializeComponent();
        }

        public ImageCompareForm Init()
        {
            //ibNew.ImageLocation = newPath;
            //ibOld.ImageLocation = oldPath;
            ShowFiles(0);
            return this;
        }

        internal void ShowFiles(int step)
        {
            try
            {
                MediaIx += step;
                if (MediaIx >= MediaFiles.Count)
                    MediaIx = 0;
                else if (MediaIx < 0)
                    MediaIx = MediaFiles.Count - 1;
                if (MediaIx >= MediaFiles.Count || MediaIx < 0)
                    return;

                MediaFile victim = MediaFiles[MediaIx];
                ibNew.ImageLocation = victim.TheFile.FullName;
                ibOld.ImageLocation = victim.Target?.ImageFilePath;
                bsMediaFile.DataSource = victim;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to display files: {ex.Message}");
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            ShowFiles(1);
        }

        private void pbPrior_Click(object sender, EventArgs e)
        {
            ShowFiles(-1);
        }
    }
}
