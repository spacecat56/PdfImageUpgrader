using PdfImageUpgrader.Model;

namespace PdfImageUpgrader
{
    public partial class Form1 : Form
    {
        private string workingDir;
        private MediaUpgradeProject _project;

        public Form1()
        {
            InitializeComponent();
        }

        private void pbPickDocx_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog()
                {
                    Title = "Choose input docx",
                    Filter = "Word Files (*.docx)|*.docx",
                    Multiselect = false
                };
                if (!string.IsNullOrWhiteSpace(tePathDocx.Text))
                    ofd.InitialDirectory = Path.GetDirectoryName(tePathDocx.Text);
                else if (workingDir != null)
                    ofd.InitialDirectory = workingDir;
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;
                tePathDocx.Text = ofd.FileName;
                workingDir = Path.GetDirectoryName(ofd.FileName);
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private void pbPickPdfIn_Click(object sender, EventArgs e)
        {
            try
            {
                //
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private void pbPickMediaDir_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog()
                {
                    InitialDirectory = workingDir ?? "",
                    Description = "Media folder"
                };
                if (fbd.ShowDialog() != DialogResult.OK)
                    return;
                tePathMediaTemp.Text = fbd.SelectedPath;
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private void pbPickPdfOut_Click(object sender, EventArgs e)
        {
            try
            {
                //
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private void pbExtractDocxMedia_Click(object sender, EventArgs e)
        {
            try
            {
                _project ??= new MediaUpgradeProject();
                _project.InputDocx = tePathDocx.Text;
                _project.MediaDir = tePathMediaTemp.Text;
                string result = _project.ExtractFromDocx();
                Log(result);
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private void pbLocatePdfImages_Click(object sender, EventArgs e)
        {
            try
            {
                _project ??= new MediaUpgradeProject();
                _project.InputPdf = tePathPdfIn.Text;
                _project.OutputPdf = tePathPdfOut.Text;
                string result = _project.InitPdf();
                Log(result);
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private void pbUpgradePdfImages_Click(object sender, EventArgs e)
        {
            try
            {
                string result = _project.UpgradePdf();
                Log(result);
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private void Notify(Exception ex)
        {
            if (InvokeRequired)
            {
                Invoke(delegate { Notify(ex); });
                return;
            }

            string s = $"Unexpected exception: {ex}";
            Log(s);
            MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void Log(string txt)
        {
            if (InvokeRequired)
            {
                Invoke(delegate { Log(txt); });
                return;
            }

            string s = $"{DateTime.Now:dd/mm/yy-HH:mm.fff} | {txt}";
            teLog.AppendText(s);
        }
    }
}
