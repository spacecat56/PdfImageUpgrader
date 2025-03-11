using PdfImageUpgrader.Model;

namespace PdfImageUpgrader
{
    public partial class ImageCompareForm : Form
    {
        public MediaFiles MediaFiles { get; set; }
        private List<FileInfo> allChoices;
        public int MediaIx { get; set; }
        internal FileInfo _choice;
        public ImageCompareForm()
        {
            InitializeComponent();
        }

        public ImageCompareForm Init()
        {
            //ibNew.ImageLocation = newPath;
            //ibOld.ImageLocation = oldPath;
            //bsChoices.DataSource = MediaFiles;
            allChoices = MediaFiles.Select(x => x.TheFile).ToList();
            cbChoose.DataSource = allChoices;
            cbChoose.DisplayMember = nameof(FileInfo.Name);
            ShowFiles(0);
            return this;
        }

        internal void ShowFiles(int step)
        {
            try
            {
                cbChoose.SelectedIndex = -1;
                pbApply.Enabled = false;
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

        private void cbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ix = cbChoose.SelectedIndex;
                if (ix < 0 || ix - 1 > MediaFiles.Count)
                    return;
                _choice = allChoices[ix];
                pbApply.Enabled = true;
                ibNew.ImageLocation = _choice.FullName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to display files: {ex.Message}");
            }

        }

        private void pbApply_Click(object sender, EventArgs e)
        {
            try
            {
                MediaFile victim = MediaFiles[MediaIx];
                victim.TheFile = _choice;
                pbApply.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to display files: {ex.Message}");
            }
        }
    }
}
