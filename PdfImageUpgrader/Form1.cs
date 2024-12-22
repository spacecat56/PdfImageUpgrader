using PdfImageUpgrader.Model;

namespace PdfImageUpgrader
{
    public partial class Form1 : Form
    {
        private string workingDir;
        private MediaUpgradeProject _project;
        public bool LogDiagnosticInfo = true;
        private bool openedImagesForm;
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
                OpenFileDialog ofd = new OpenFileDialog()
                {
                    Title = "Choose input pdf; MUST match docx",
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Multiselect = false
                };
                if (!string.IsNullOrWhiteSpace(tePathPdfIn.Text))
                    ofd.InitialDirectory = Path.GetDirectoryName(tePathPdfIn.Text);
                else if (workingDir != null)
                    ofd.InitialDirectory = workingDir;
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;
                tePathPdfIn.Text = ofd.FileName;
                tePathPdfOut.Text = Path.ChangeExtension(ofd.FileName, "_upgraded.pdf").Replace("._upgraded","_upgraded");
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
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Choose output pdf;",
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    CheckFileExists = true
                };
                if (!string.IsNullOrWhiteSpace(tePathPdfOut.Text))
                    sfd.InitialDirectory = Path.GetDirectoryName(tePathPdfOut.Text);
                else if (workingDir != null)
                    sfd.InitialDirectory = workingDir;
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                tePathPdfOut.Text = sfd.FileName;
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

        private async void pbLocatePdfImages_Click(object sender, EventArgs e)
        {
            try
            {
                // NB gross defect this cannot be made to work!
                Application.UseWaitCursor = pbLocatePdfImages.UseWaitCursor = true;
                Application.DoEvents();
               
                _project ??= new MediaUpgradeProject();
                _project.InputPdf = tePathPdfIn.Text;
                _project.OutputPdf = tePathPdfOut.Text;

                string result = _project.InitPdf();
                Log(result);
                bsMediaFiles.DataSource = _project.MediaFiles;

                if (!LogDiagnosticInfo) return;
                Log(_project.PdfWrangler.DiagnosticInfo.ToString());
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
            finally
            {
                Application.UseWaitCursor = pbLocatePdfImages.UseWaitCursor = false;
            }
        }

        private void pbUpgradePdfImages_Click(object sender, EventArgs e)
        {
            try
            {
                Application.UseWaitCursor = pbUpgradePdfImages.UseWaitCursor = true;
                Application.DoEvents();
                _project.OutputPdf = tePathPdfOut.Text;
                string result = _project.UpgradePdf();
                Log(result);
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
            finally
            {
                Application.UseWaitCursor = pbUpgradePdfImages.UseWaitCursor = false;
            }
        }
        private void pbViewImages_Click(object sender, EventArgs e)
        {
            try
            {
                if ((_project.MediaFiles?.Count ?? 0) == 0) return;
                int vicIx = (dgMediaFiles.SelectedRows.Count == 0)
                    ? 0 
                    : dgMediaFiles.SelectedRows[0].Index;
                ImageCompareForm icf =
                    new ImageCompareForm() { MediaFiles = _project.MediaFiles, MediaIx = vicIx }.Init();
                icf.Show(this);
                openedImagesForm = true;
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
            if (string.IsNullOrWhiteSpace(txt))
                return;

            if (InvokeRequired)
            {
                Invoke(delegate { Log(txt); });
                return;
            }

            string s = $"{DateTime.Now:dd/MM/yy-HH:mm:ss.fff} | {txt}";
            teLog.AppendText(s);
            if (!s.EndsWith(Environment.NewLine))
                teLog.AppendText(Environment.NewLine);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // since we are not using a binding-aware collection 
            // we need to make sure that changes made on the image compare form
            // show up here
            if (!openedImagesForm) return;
            bsMediaFiles.ResetBindings(false);
        }
    }
}
