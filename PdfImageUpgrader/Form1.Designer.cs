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
            SuspendLayout();
            // 
            // teLog
            // 
            teLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teLog.Location = new Point(13, 335);
            teLog.Multiline = true;
            teLog.Name = "teLog";
            teLog.ScrollBars = ScrollBars.Vertical;
            teLog.Size = new Size(855, 327);
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
            tePathDocx.Size = new Size(680, 27);
            tePathDocx.TabIndex = 2;
            tePathDocx.Text = "C:\\Users\\shanley\\DocumentsLocal\\_wipLocal\\_testTemp\\ShancurryShanleys___Rev-34j___highCoveragePages_optRev-03.docx";
            // 
            // pbPickDocx
            // 
            pbPickDocx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPickDocx.Location = new Point(827, 34);
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
            pbPickPdfIn.Location = new Point(827, 67);
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
            tePathPdfIn.Size = new Size(680, 27);
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
            pbPickMediaDir.Location = new Point(827, 100);
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
            tePathMediaTemp.Size = new Size(680, 27);
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
            pbPickPdfOut.Location = new Point(827, 133);
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
            tePathPdfOut.Size = new Size(680, 27);
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
            pbUpgradePdfImages.Location = new Point(607, 193);
            pbUpgradePdfImages.Name = "pbUpgradePdfImages";
            pbUpgradePdfImages.Size = new Size(261, 112);
            pbUpgradePdfImages.TabIndex = 15;
            pbUpgradePdfImages.Text = "Upgrade  pdf Images";
            pbUpgradePdfImages.UseVisualStyleBackColor = true;
            pbUpgradePdfImages.Click += pbUpgradePdfImages_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 681);
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
    }
}
