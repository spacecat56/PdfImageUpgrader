using PdfImageUpgrader.Model;
using PdfImageUpgrader.Properties;

namespace PdfImageUpgrader
{
    public partial class Form1 : Form
    {
        private string workingDir;
        private MediaUpgradeProject _project;
        private bool openedImagesForm;
        private bool didSomeExtractions;
        public Form1()
        {
            InitializeComponent();
            lockables = new List<Control>()
            {
                tePathPdfIn, tePathDocx, tePathMediaTemp, tePathPdfOut,
                pbLocatePdfImages, pbExtractDocxMedia, pbPickDocx, pbPickMediaDir,
                pbPickPdfIn, pbPickPdfOut, pbUpgradePdfImages, pbViewImages,
                dgMediaFiles
            };
            BindSettings();
        }

        private List<Control> lockables;

        private void ToggleUI(bool ena, Control except)
        {
            if (InvokeRequired)
            {
                Invoke(delegate { ToggleUI(ena, except); });
                return;
            }

            foreach (Control c in lockables)
            {
                if (c == except) continue;
                c.Enabled = ena;
            }
        }

        private void BindSettings()
        {
            Binding b = new Binding("Checked", Properties.Settings.Default, "CleanupOnExit");
            kbCleanupOnExit.DataBindings.Add(b);
            b = new Binding("Checked", Properties.Settings.Default, "LogDiagnostics");
            kbLogDiagnostics.DataBindings.Add(b);
            b = new Binding("SelectedItem", Properties.Settings.Default, "ComparisonAlgorithm");
            cbAlgorithm.DataBindings.Add(b);
            b = new Binding("Value", Properties.Settings.Default, "MatchCutoff");
            nudMaxMatch.DataBindings.Add(b);
            b = new Binding("Value", Properties.Settings.Default, "ModCutoff");
            nudMaxMod.DataBindings.Add(b);
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
                tePathPdfOut.Text = Path.ChangeExtension(ofd.FileName, "_upgraded.pdf").Replace("._upgraded", "_upgraded");
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
                InitProject();
                string result = _project.ExtractFromDocx();
                Log(result, true);
                pbLocatePdfImages.Enabled = didSomeExtractions = _project.MediaFiles.Count > 0;
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private void InitProject()
        {
            _project ??= new MediaUpgradeProject();
            _project.InputDocx = tePathDocx.Text;
            _project.MediaDir = tePathMediaTemp.Text;
            _project.ErrorMetric = Settings.Default.ComparisonAlgorithm;
            _project.MatchCutoff = Settings.Default.MatchCutoff;
            _project.ModCutoff = Settings.Default.ModCutoff;
        }

        private void PostProcessLocate(string txt)
        {
            if (InvokeRequired)
            {
                Invoke(delegate { PostProcessLocate(txt); });
                return;
            }
            try
            {
                Log("FINISH locate pdf images", true);
                Log(txt);
                if (bsMediaFiles.DataSource == _project.MediaFiles)
                    bsMediaFiles.ResetBindings(false);
                else
                    bsMediaFiles.DataSource = _project.MediaFiles;

                if (!Properties.Settings.Default.LogDiagnostics) return;
                Log(_project.PdfWrangler.DiagnosticInfo.ToString());
                pbUpgradePdfImages.Enabled = _project.HasMatches();
                pbViewImages.Enabled = _project.MediaFiles.Count > 0;
                didSomeExtractions = true;
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
            finally
            {
                pbLocatePdfImages.Text = "Locate pdf Images";
                ToggleUI(true, null);
                Application.UseWaitCursor = pbLocatePdfImages.UseWaitCursor = dgMediaFiles.UseWaitCursor = false;
            }
        }

        private async void pbLocatePdfImages_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbLocatePdfImages.Text == "Cancel")
                {
                    Log("Cancel requested", true);
                    _project.PdfWrangler.CancelRequested = true;
                    return;
                }

                Application.UseWaitCursor = pbLocatePdfImages.UseWaitCursor = true;
                Application.DoEvents();
                pbLocatePdfImages.Text = "Cancel";
                ToggleUI(false, pbLocatePdfImages);

                InitProject();
                _project.InputPdf = tePathPdfIn.Text;

                Log("BEGIN locate pdf images", true);
                await Task.Run(() => _project.InitPdf()).ContinueWith(t => PostProcessLocate(t.Result));
            }
            catch (Exception ex)
            {
                pbLocatePdfImages.Text = "Locate pdf Images";
                ToggleUI(true, null);
                Application.UseWaitCursor = pbLocatePdfImages.UseWaitCursor = false;
                Notify(ex);
            }
        }

        private void PostProcessUpgrade(string txt)
        {
            if (InvokeRequired)
            {
                Invoke(delegate { PostProcessUpgrade(txt); });
                return;
            }

            try
            {
                Log("FINISH upgrade pdf images", true);
                Log(txt);
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
            finally
            {
                pbUpgradePdfImages.Text = "Upgrade pdf Images";
                ToggleUI(true, null);
                Application.UseWaitCursor = pbUpgradePdfImages.UseWaitCursor = dgMediaFiles.UseWaitCursor = false;
            }
        }

        private async void pbUpgradePdfImages_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbUpgradePdfImages.Text == "Cancel")
                {
                    Log("Cancel requested", true);
                    _project.PdfWrangler.CancelRequested = true;
                    return;
                }

                _project.OutputPdf = tePathPdfOut.Text;
                pbUpgradePdfImages.Text = "Cancel";
                ToggleUI(false, pbUpgradePdfImages);
                Application.UseWaitCursor = pbUpgradePdfImages.UseWaitCursor = true;
                Application.DoEvents();

                Log("BEGIN upgrade pdf images", true);
                await Task.Run(() => _project.UpgradePdf()).ContinueWith(t => PostProcessUpgrade(t.Result));
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

            Log($"Exception:{ex.Message}", true);
            string s = $"Unexpected exception: {ex}";
            Log(s);
            MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void Log(string txt, bool showOnStatus = false)
        {
            if (string.IsNullOrWhiteSpace(txt))
                return;

            if (InvokeRequired)
            {
                Invoke(delegate { Log(txt, showOnStatus); });
                return;
            }

            string s = $"{DateTime.Now:dd/MM/yy-HH:mm:ss.fff} | {txt}";
            teLog.AppendText(s);
            if (!s.EndsWith(Environment.NewLine))
                teLog.AppendText(Environment.NewLine);
            if (!showOnStatus) return;
            int ix = s.IndexOf("\r\n");
            if (ix > 0) s = s.Substring(0, ix);
            slLog.Text = s;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // since we are not using a binding-aware collection 
            // we need to make sure that changes made on the image compare form
            // show up here
            if (!openedImagesForm) return;
            bsMediaFiles.ResetBindings(false);
        }

        private void miReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (!OptionalDeleteMedia())
                    return;
                tePathPdfIn.Text = tePathDocx.Text
                    = tePathMediaTemp.Text = tePathPdfOut.Text
                    = "";
                pbUpgradePdfImages.Enabled = pbViewImages.Enabled = pbLocatePdfImages.Enabled = false;
                bsMediaFiles.DataSource = new List<MediaFile>();
                _project = null;

                Log("Reset", true);
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private bool OptionalDeleteMedia()
        {
            if (!didSomeExtractions
                || string.IsNullOrWhiteSpace(tePathMediaTemp.Text)
                || !Directory.Exists(tePathMediaTemp.Text))
                return true; // ok here

            DialogResult dr = MessageBox.Show("Delete the temp media directory?", "Confirm setting",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                Log("Action Canceled", true);
                return false;
            }
            if (dr == DialogResult.No)
            {
                Log("User chose not to delete temp media", true);
                return true;
            }
            Directory.Delete(tePathMediaTemp.Text, true);
            Log($"Deleted {tePathMediaTemp.Text}", true);
            return true;
        }

        private void pbSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!didSomeExtractions || string.IsNullOrWhiteSpace(tePathMediaTemp.Text) || !Directory.Exists(tePathMediaTemp.Text)) return; // ok here
                if (!Properties.Settings.Default.CleanupOnExit)
                    return;
                DialogResult dr = MessageBox.Show("Delete the temp media directory?", "Confirm setting",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    Log("Exit Canceled", true);
                    e.Cancel = true;
                    return;
                }
                if (dr == DialogResult.No)
                {
                    Log("User chose not to delete temp media");
                    return;
                }
                Directory.Delete(tePathMediaTemp.Text, true);
                Log($"Deleted {tePathMediaTemp.Text}", true);
            }
            catch (Exception ex)
            {
                Notify(ex);
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog(this);
        }
    }
}
