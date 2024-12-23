namespace PdfImageUpgrader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            teLog = new TextBox();
            label1 = new Label();
            tePathDocx = new TextBox();
            pbPickDocx = new Button();
            pbPickPdfIn = new Button();
            tePathPdfIn = new TextBox();
            label2 = new Label();
            pbPickMediaDir = new Button();
            tePathMediaTemp = new TextBox();
            label3 = new Label();
            pbPickPdfOut = new Button();
            tePathPdfOut = new TextBox();
            label4 = new Label();
            pbExtractDocxMedia = new Button();
            pbLocatePdfImages = new Button();
            pbUpgradePdfImages = new Button();
            bsMediaFiles = new BindingSource(components);
            dgMediaFiles = new DataGridView();
            docxImageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            targetPageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageToReplaceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ImageMetric = new DataGridViewTextBoxColumn();
            okToApplyDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            pbViewImages = new Button();
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            nudMaxMod = new NumericUpDown();
            nudMaxMatch = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbAlgorithm = new ComboBox();
            label5 = new Label();
            pbSaveSettings = new Button();
            kbLogDiagnostics = new CheckBox();
            kbCleanupOnExit = new CheckBox();
            statusStrip1 = new StatusStrip();
            slLog = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            miReset = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            miExit = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            miAbout = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bsMediaFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMediaFiles).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxMod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxMatch).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // teLog
            // 
            teLog.Dock = DockStyle.Fill;
            teLog.Location = new Point(3, 3);
            teLog.Multiline = true;
            teLog.Name = "teLog";
            teLog.ScrollBars = ScrollBars.Vertical;
            teLog.Size = new Size(953, 601);
            teLog.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Docx input file";
            // 
            // tePathDocx
            // 
            tePathDocx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tePathDocx.Location = new Point(144, 22);
            tePathDocx.Name = "tePathDocx";
            tePathDocx.Size = new Size(743, 27);
            tePathDocx.TabIndex = 2;
            // 
            // pbPickDocx
            // 
            pbPickDocx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPickDocx.Location = new Point(893, 22);
            pbPickDocx.Name = "pbPickDocx";
            pbPickDocx.Size = new Size(41, 27);
            pbPickDocx.TabIndex = 3;
            pbPickDocx.Text = "...";
            pbPickDocx.UseVisualStyleBackColor = true;
            pbPickDocx.Click += pbPickDocx_Click;
            // 
            // pbPickPdfIn
            // 
            pbPickPdfIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPickPdfIn.Location = new Point(893, 55);
            pbPickPdfIn.Name = "pbPickPdfIn";
            pbPickPdfIn.Size = new Size(41, 27);
            pbPickPdfIn.TabIndex = 6;
            pbPickPdfIn.Text = "...";
            pbPickPdfIn.UseVisualStyleBackColor = true;
            pbPickPdfIn.Click += pbPickPdfIn_Click;
            // 
            // tePathPdfIn
            // 
            tePathPdfIn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tePathPdfIn.Location = new Point(144, 55);
            tePathPdfIn.Name = "tePathPdfIn";
            tePathPdfIn.Size = new Size(743, 27);
            tePathPdfIn.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 58);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "PDF input file";
            // 
            // pbPickMediaDir
            // 
            pbPickMediaDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPickMediaDir.Location = new Point(893, 88);
            pbPickMediaDir.Name = "pbPickMediaDir";
            pbPickMediaDir.Size = new Size(41, 27);
            pbPickMediaDir.TabIndex = 9;
            pbPickMediaDir.Text = "...";
            pbPickMediaDir.UseVisualStyleBackColor = true;
            pbPickMediaDir.Click += pbPickMediaDir_Click;
            // 
            // tePathMediaTemp
            // 
            tePathMediaTemp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tePathMediaTemp.Location = new Point(144, 88);
            tePathMediaTemp.Name = "tePathMediaTemp";
            tePathMediaTemp.Size = new Size(743, 27);
            tePathMediaTemp.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 91);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 7;
            label3.Text = "Temp image dir";
            // 
            // pbPickPdfOut
            // 
            pbPickPdfOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPickPdfOut.Location = new Point(893, 121);
            pbPickPdfOut.Name = "pbPickPdfOut";
            pbPickPdfOut.Size = new Size(41, 27);
            pbPickPdfOut.TabIndex = 12;
            pbPickPdfOut.Text = "...";
            pbPickPdfOut.UseVisualStyleBackColor = true;
            pbPickPdfOut.Click += pbPickPdfOut_Click;
            // 
            // tePathPdfOut
            // 
            tePathPdfOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tePathPdfOut.Location = new Point(144, 121);
            tePathPdfOut.Name = "tePathPdfOut";
            tePathPdfOut.Size = new Size(743, 27);
            tePathPdfOut.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 124);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 10;
            label4.Text = "PDF output file";
            // 
            // pbExtractDocxMedia
            // 
            pbExtractDocxMedia.Font = new Font("Segoe UI", 18F);
            pbExtractDocxMedia.Location = new Point(20, 181);
            pbExtractDocxMedia.Name = "pbExtractDocxMedia";
            pbExtractDocxMedia.Size = new Size(261, 112);
            pbExtractDocxMedia.TabIndex = 13;
            pbExtractDocxMedia.Text = "Extract docx Media";
            pbExtractDocxMedia.UseVisualStyleBackColor = true;
            pbExtractDocxMedia.Click += pbExtractDocxMedia_Click;
            // 
            // pbLocatePdfImages
            // 
            pbLocatePdfImages.Enabled = false;
            pbLocatePdfImages.Font = new Font("Segoe UI", 18F);
            pbLocatePdfImages.Location = new Point(320, 181);
            pbLocatePdfImages.Name = "pbLocatePdfImages";
            pbLocatePdfImages.Size = new Size(261, 112);
            pbLocatePdfImages.TabIndex = 14;
            pbLocatePdfImages.Text = "Locate pdf Images";
            pbLocatePdfImages.UseVisualStyleBackColor = true;
            pbLocatePdfImages.Click += pbLocatePdfImages_Click;
            // 
            // pbUpgradePdfImages
            // 
            pbUpgradePdfImages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUpgradePdfImages.Enabled = false;
            pbUpgradePdfImages.Font = new Font("Segoe UI", 18F);
            pbUpgradePdfImages.Location = new Point(735, 445);
            pbUpgradePdfImages.Name = "pbUpgradePdfImages";
            pbUpgradePdfImages.Size = new Size(202, 112);
            pbUpgradePdfImages.TabIndex = 15;
            pbUpgradePdfImages.Text = "Upgrade pdf Images";
            pbUpgradePdfImages.UseVisualStyleBackColor = true;
            pbUpgradePdfImages.Click += pbUpgradePdfImages_Click;
            // 
            // bsMediaFiles
            // 
            bsMediaFiles.DataSource = typeof(Model.MediaFiles);
            // 
            // dgMediaFiles
            // 
            dgMediaFiles.AllowUserToAddRows = false;
            dgMediaFiles.AllowUserToDeleteRows = false;
            dgMediaFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgMediaFiles.AutoGenerateColumns = false;
            dgMediaFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMediaFiles.Columns.AddRange(new DataGridViewColumn[] { docxImageDataGridViewTextBoxColumn, targetPageDataGridViewTextBoxColumn, imageToReplaceDataGridViewTextBoxColumn, ImageMetric, okToApplyDataGridViewCheckBoxColumn });
            dgMediaFiles.DataSource = bsMediaFiles;
            dgMediaFiles.Location = new Point(20, 318);
            dgMediaFiles.MultiSelect = false;
            dgMediaFiles.Name = "dgMediaFiles";
            dgMediaFiles.Size = new Size(692, 239);
            dgMediaFiles.TabIndex = 16;
            // 
            // docxImageDataGridViewTextBoxColumn
            // 
            docxImageDataGridViewTextBoxColumn.DataPropertyName = "DocxImage";
            docxImageDataGridViewTextBoxColumn.HeaderText = "Docx Image";
            docxImageDataGridViewTextBoxColumn.Name = "docxImageDataGridViewTextBoxColumn";
            docxImageDataGridViewTextBoxColumn.ReadOnly = true;
            docxImageDataGridViewTextBoxColumn.Width = 120;
            // 
            // targetPageDataGridViewTextBoxColumn
            // 
            targetPageDataGridViewTextBoxColumn.DataPropertyName = "TargetPage";
            targetPageDataGridViewTextBoxColumn.HeaderText = "Target Page";
            targetPageDataGridViewTextBoxColumn.Name = "targetPageDataGridViewTextBoxColumn";
            targetPageDataGridViewTextBoxColumn.ReadOnly = true;
            targetPageDataGridViewTextBoxColumn.Width = 120;
            // 
            // imageToReplaceDataGridViewTextBoxColumn
            // 
            imageToReplaceDataGridViewTextBoxColumn.DataPropertyName = "ImageToReplace";
            imageToReplaceDataGridViewTextBoxColumn.HeaderText = "Image To Replace";
            imageToReplaceDataGridViewTextBoxColumn.Name = "imageToReplaceDataGridViewTextBoxColumn";
            imageToReplaceDataGridViewTextBoxColumn.ReadOnly = true;
            imageToReplaceDataGridViewTextBoxColumn.Width = 180;
            // 
            // ImageMetric
            // 
            ImageMetric.DataPropertyName = "ImageMetric";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            ImageMetric.DefaultCellStyle = dataGridViewCellStyle1;
            ImageMetric.HeaderText = "Image Metric";
            ImageMetric.Name = "ImageMetric";
            ImageMetric.ReadOnly = true;
            ImageMetric.Width = 120;
            // 
            // okToApplyDataGridViewCheckBoxColumn
            // 
            okToApplyDataGridViewCheckBoxColumn.DataPropertyName = "OkToApply";
            okToApplyDataGridViewCheckBoxColumn.HeaderText = "Ok To Apply";
            okToApplyDataGridViewCheckBoxColumn.Name = "okToApplyDataGridViewCheckBoxColumn";
            okToApplyDataGridViewCheckBoxColumn.ToolTipText = "Deslect to prevent this replacement";
            // 
            // pbViewImages
            // 
            pbViewImages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbViewImages.Enabled = false;
            pbViewImages.Font = new Font("Segoe UI", 18F);
            pbViewImages.Location = new Point(735, 318);
            pbViewImages.Name = "pbViewImages";
            pbViewImages.Size = new Size(199, 111);
            pbViewImages.TabIndex = 17;
            pbViewImages.Text = "View selected";
            toolTip1.SetToolTip(pbViewImages, "View images");
            pbViewImages.UseVisualStyleBackColor = true;
            pbViewImages.Click += pbViewImages_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(967, 635);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pbViewImages);
            tabPage1.Controls.Add(tePathDocx);
            tabPage1.Controls.Add(dgMediaFiles);
            tabPage1.Controls.Add(pbPickDocx);
            tabPage1.Controls.Add(pbUpgradePdfImages);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(pbLocatePdfImages);
            tabPage1.Controls.Add(tePathPdfIn);
            tabPage1.Controls.Add(pbExtractDocxMedia);
            tabPage1.Controls.Add(pbPickPdfIn);
            tabPage1.Controls.Add(pbPickPdfOut);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(tePathPdfOut);
            tabPage1.Controls.Add(tePathMediaTemp);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(pbPickMediaDir);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(959, 602);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Processing";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(teLog);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(959, 607);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Log";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Controls.Add(nudMaxMod);
            tabPage3.Controls.Add(nudMaxMatch);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(cbAlgorithm);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(pbSaveSettings);
            tabPage3.Controls.Add(kbLogDiagnostics);
            tabPage3.Controls.Add(kbCleanupOnExit);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(959, 607);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            // 
            // nudMaxMod
            // 
            nudMaxMod.DecimalPlaces = 3;
            nudMaxMod.Location = new Point(310, 200);
            nudMaxMod.Name = "nudMaxMod";
            nudMaxMod.RightToLeft = RightToLeft.Yes;
            nudMaxMod.Size = new Size(120, 27);
            nudMaxMod.TabIndex = 9;
            // 
            // nudMaxMatch
            // 
            nudMaxMatch.DecimalPlaces = 3;
            nudMaxMatch.Location = new Point(310, 167);
            nudMaxMatch.Name = "nudMaxMatch";
            nudMaxMatch.RightToLeft = RightToLeft.Yes;
            nudMaxMatch.Size = new Size(120, 27);
            nudMaxMatch.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 202);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 7;
            label8.Text = "Max error for mod";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 169);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 6;
            label7.Text = "Max error for match";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(100, 471);
            label6.Name = "label6";
            label6.Size = new Size(705, 75);
            label6.TabIndex = 5;
            label6.Text = resources.GetString("label6.Text");
            // 
            // cbAlgorithm
            // 
            cbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlgorithm.FormattingEnabled = true;
            cbAlgorithm.Items.AddRange(new object[] { "Fuzz", "MeanErrorPerPixel", "MeanSquared", "PerceptualHash" });
            cbAlgorithm.Location = new Point(310, 131);
            cbAlgorithm.Name = "cbAlgorithm";
            cbAlgorithm.Size = new Size(186, 28);
            cbAlgorithm.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 134);
            label5.Name = "label5";
            label5.Size = new Size(187, 20);
            label5.TabIndex = 3;
            label5.Text = "Image Comparison Metric*";
            // 
            // pbSaveSettings
            // 
            pbSaveSettings.Location = new Point(104, 317);
            pbSaveSettings.Name = "pbSaveSettings";
            pbSaveSettings.Size = new Size(84, 37);
            pbSaveSettings.TabIndex = 2;
            pbSaveSettings.Text = "Save";
            pbSaveSettings.UseVisualStyleBackColor = true;
            pbSaveSettings.Click += pbSaveSettings_Click;
            // 
            // kbLogDiagnostics
            // 
            kbLogDiagnostics.AutoSize = true;
            kbLogDiagnostics.Location = new Point(105, 98);
            kbLogDiagnostics.Name = "kbLogDiagnostics";
            kbLogDiagnostics.Size = new Size(204, 24);
            kbLogDiagnostics.TabIndex = 1;
            kbLogDiagnostics.Text = "Log additional diagnostics";
            kbLogDiagnostics.UseVisualStyleBackColor = true;
            // 
            // kbCleanupOnExit
            // 
            kbCleanupOnExit.AutoSize = true;
            kbCleanupOnExit.Location = new Point(105, 66);
            kbCleanupOnExit.Name = "kbCleanupOnExit";
            kbCleanupOnExit.Size = new Size(131, 24);
            kbCleanupOnExit.TabIndex = 0;
            kbCleanupOnExit.Text = "Cleanup on exit";
            kbCleanupOnExit.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Items.AddRange(new ToolStripItem[] { slLog });
            statusStrip1.Location = new Point(0, 702);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(994, 22);
            statusStrip1.TabIndex = 19;
            statusStrip1.Text = "statusStrip1";
            // 
            // slLog
            // 
            slLog.Name = "slLog";
            slLog.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(994, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miReset, toolStripMenuItem1, miExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // miReset
            // 
            miReset.Name = "miReset";
            miReset.Size = new Size(102, 22);
            miReset.Text = "Reset";
            miReset.Click += miReset_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(99, 6);
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(102, 22);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miAbout });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // miAbout
            // 
            miAbout.Name = "miAbout";
            miAbout.Size = new Size(107, 22);
            miAbout.Text = "About";
            miAbout.Click += miAbout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(994, 724);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 11F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "PDF Image Upgrader";
            Activated += Form1_Activated;
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)bsMediaFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMediaFiles).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxMod).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxMatch).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teLog;
        private Label label1;
        private TextBox tePathDocx;
        private Button pbPickDocx;
        private Button pbPickPdfIn;
        private TextBox tePathPdfIn;
        private Label label2;
        private Button pbPickMediaDir;
        private TextBox tePathMediaTemp;
        private Label label3;
        private Button pbPickPdfOut;
        private TextBox tePathPdfOut;
        private Label label4;
        private Button pbExtractDocxMedia;
        private Button pbLocatePdfImages;
        private Button pbUpgradePdfImages;
        private BindingSource bsMediaFiles;
        private DataGridView dgMediaFiles;
        private Button pbViewImages;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn imageMetricDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docxImageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn targetPageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imageToReplaceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ImageMetric;
        private DataGridViewCheckBoxColumn okToApplyDataGridViewCheckBoxColumn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slLog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem miReset;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem miExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem miAbout;
        private CheckBox kbLogDiagnostics;
        private CheckBox kbCleanupOnExit;
        private Button pbSaveSettings;
        private ComboBox cbAlgorithm;
        private Label label5;
        private Label label6;
        private NumericUpDown nudMaxMod;
        private NumericUpDown nudMaxMatch;
        private Label label8;
        private Label label7;
    }
}
