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
            ((System.ComponentModel.ISupportInitialize)bsMediaFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMediaFiles).BeginInit();
            SuspendLayout();
            // 
            // teLog
            // 
            teLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teLog.Location = new Point(13, 591);
            teLog.Multiline = true;
            teLog.Name = "teLog";
            teLog.ScrollBars = ScrollBars.Vertical;
            teLog.Size = new Size(924, 453);
            teLog.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 37);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Docx input file";
            // 
            // tePathDocx
            // 
            tePathDocx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tePathDocx.Location = new Point(137, 34);
            tePathDocx.Name = "tePathDocx";
            tePathDocx.Size = new Size(749, 27);
            tePathDocx.TabIndex = 2;
            tePathDocx.Text = "C:\\Users\\shanley\\DocumentsLocal\\_wipLocal\\_testTemp\\ShancurryShanleys___Rev-34j___highCoveragePages_optRev-03.docx";
            // 
            // pbPickDocx
            // 
            pbPickDocx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPickDocx.Location = new Point(896, 34);
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
            pbPickPdfIn.Location = new Point(896, 67);
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
            tePathPdfIn.Location = new Point(137, 67);
            tePathPdfIn.Name = "tePathPdfIn";
            tePathPdfIn.Size = new Size(749, 27);
            tePathPdfIn.TabIndex = 5;
            tePathPdfIn.Text = "C:\\Users\\shanley\\DocumentsLocal\\_wipLocal\\_testTemp\\ShancurryShanleys___Rev-34j___highCoveragePages_optRev-03.pdf";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 70);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "PDF input file";
            // 
            // pbPickMediaDir
            // 
            pbPickMediaDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPickMediaDir.Location = new Point(896, 100);
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
            tePathMediaTemp.Location = new Point(137, 100);
            tePathMediaTemp.Name = "tePathMediaTemp";
            tePathMediaTemp.Size = new Size(749, 27);
            tePathMediaTemp.TabIndex = 8;
            tePathMediaTemp.Text = "C:\\Users\\shanley\\DocumentsLocal\\_wipLocal\\_testTemp\\Media";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 103);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 7;
            label3.Text = "Temp image dir";
            // 
            // pbPickPdfOut
            // 
            pbPickPdfOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPickPdfOut.Location = new Point(896, 133);
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
            tePathPdfOut.Location = new Point(137, 133);
            tePathPdfOut.Name = "tePathPdfOut";
            tePathPdfOut.Size = new Size(749, 27);
            tePathPdfOut.TabIndex = 11;
            tePathPdfOut.Text = "C:\\Users\\shanley\\DocumentsLocal\\_wipLocal\\_testTemp\\ShancurryShanleys___Rev-34j___highCoveragePages_optRev-03_upgraded.pdf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 136);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 10;
            label4.Text = "PDF output file";
            // 
            // pbExtractDocxMedia
            // 
            pbExtractDocxMedia.Font = new Font("Segoe UI", 18F);
            pbExtractDocxMedia.Location = new Point(13, 193);
            pbExtractDocxMedia.Name = "pbExtractDocxMedia";
            pbExtractDocxMedia.Size = new Size(261, 112);
            pbExtractDocxMedia.TabIndex = 13;
            pbExtractDocxMedia.Text = "Extract docx Media";
            pbExtractDocxMedia.UseVisualStyleBackColor = true;
            pbExtractDocxMedia.Click += pbExtractDocxMedia_Click;
            // 
            // pbLocatePdfImages
            // 
            pbLocatePdfImages.Font = new Font("Segoe UI", 18F);
            pbLocatePdfImages.Location = new Point(313, 193);
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
            pbUpgradePdfImages.Font = new Font("Segoe UI", 18F);
            pbUpgradePdfImages.Location = new Point(738, 457);
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
            dgMediaFiles.Location = new Point(13, 330);
            dgMediaFiles.MultiSelect = false;
            dgMediaFiles.Name = "dgMediaFiles";
            dgMediaFiles.Size = new Size(716, 239);
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
            pbViewImages.Font = new Font("Segoe UI", 18F);
            pbViewImages.Location = new Point(738, 330);
            pbViewImages.Name = "pbViewImages";
            pbViewImages.Size = new Size(199, 111);
            pbViewImages.TabIndex = 17;
            pbViewImages.Text = "View selected";
            toolTip1.SetToolTip(pbViewImages, "View images");
            pbViewImages.UseVisualStyleBackColor = true;
            pbViewImages.Click += pbViewImages_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 1063);
            Controls.Add(pbViewImages);
            Controls.Add(dgMediaFiles);
            Controls.Add(pbUpgradePdfImages);
            Controls.Add(pbLocatePdfImages);
            Controls.Add(pbExtractDocxMedia);
            Controls.Add(pbPickPdfOut);
            Controls.Add(tePathPdfOut);
            Controls.Add(label4);
            Controls.Add(pbPickMediaDir);
            Controls.Add(tePathMediaTemp);
            Controls.Add(label3);
            Controls.Add(pbPickPdfIn);
            Controls.Add(tePathPdfIn);
            Controls.Add(label2);
            Controls.Add(pbPickDocx);
            Controls.Add(tePathDocx);
            Controls.Add(label1);
            Controls.Add(teLog);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "PDF Image Upgrader";
            Activated += Form1_Activated;
            ((System.ComponentModel.ISupportInitialize)bsMediaFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMediaFiles).EndInit();
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
    }
}
