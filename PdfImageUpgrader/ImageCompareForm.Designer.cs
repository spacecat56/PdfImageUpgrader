namespace PdfImageUpgrader
{
    partial class ImageCompareForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            ibNew = new PictureBox();
            pnLeftTop = new Panel();
            pbApply = new Button();
            cbChoose = new ComboBox();
            bsChoices = new BindingSource(components);
            checkBox1 = new CheckBox();
            bsMediaFile = new BindingSource(components);
            pbPrior = new Button();
            pbNext = new Button();
            label1 = new Label();
            ibOld = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            lbNewName = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ibNew).BeginInit();
            pnLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsChoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMediaFile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ibOld).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ibNew);
            splitContainer1.Panel1.Controls.Add(pnLeftTop);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ibOld);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1184, 947);
            splitContainer1.SplitterDistance = 800;
            splitContainer1.TabIndex = 0;
            // 
            // ibNew
            // 
            ibNew.Dock = DockStyle.Fill;
            ibNew.Location = new Point(0, 46);
            ibNew.Name = "ibNew";
            ibNew.Size = new Size(800, 901);
            ibNew.TabIndex = 0;
            ibNew.TabStop = false;
            // 
            // pnLeftTop
            // 
            pnLeftTop.Controls.Add(lbNewName);
            pnLeftTop.Controls.Add(pbApply);
            pnLeftTop.Controls.Add(cbChoose);
            pnLeftTop.Controls.Add(checkBox1);
            pnLeftTop.Controls.Add(pbPrior);
            pnLeftTop.Controls.Add(pbNext);
            pnLeftTop.Controls.Add(label1);
            pnLeftTop.Dock = DockStyle.Top;
            pnLeftTop.Location = new Point(0, 0);
            pnLeftTop.Name = "pnLeftTop";
            pnLeftTop.Size = new Size(800, 46);
            pnLeftTop.TabIndex = 1;
            // 
            // pbApply
            // 
            pbApply.Enabled = false;
            pbApply.Location = new Point(403, 6);
            pbApply.Name = "pbApply";
            pbApply.Size = new Size(64, 32);
            pbApply.TabIndex = 5;
            pbApply.Text = "Apply";
            pbApply.UseVisualStyleBackColor = true;
            pbApply.Click += pbApply_Click;
            // 
            // cbChoose
            // 
            cbChoose.DataSource = bsChoices;
            cbChoose.DisplayMember = "Name";
            cbChoose.FormattingEnabled = true;
            cbChoose.Location = new Point(273, 12);
            cbChoose.Name = "cbChoose";
            cbChoose.Size = new Size(121, 23);
            cbChoose.TabIndex = 4;
            toolTip1.SetToolTip(cbChoose, "Optially coose (review) a different repalcement");
            cbChoose.SelectedIndexChanged += cbChoose_SelectedIndexChanged;
            // 
            // bsChoices
            // 
            bsChoices.DataSource = typeof(Model.MediaFiles);
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("Checked", bsMediaFile, "OkToApply", true));
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(515, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 25);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Enable";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // bsMediaFile
            // 
            bsMediaFile.DataSource = typeof(Model.MediaFile);
            // 
            // pbPrior
            // 
            pbPrior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPrior.Location = new Point(632, 6);
            pbPrior.Name = "pbPrior";
            pbPrior.Size = new Size(75, 34);
            pbPrior.TabIndex = 2;
            pbPrior.Text = "Prior";
            pbPrior.UseVisualStyleBackColor = true;
            pbPrior.Click += pbPrior_Click;
            // 
            // pbNext
            // 
            pbNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNext.Location = new Point(713, 6);
            pbNext.Name = "pbNext";
            pbNext.Size = new Size(75, 34);
            pbNext.TabIndex = 1;
            pbNext.Text = "Next";
            pbNext.UseVisualStyleBackColor = true;
            pbNext.Click += pbNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(26, 13);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "New Image ";
            // 
            // ibOld
            // 
            ibOld.Dock = DockStyle.Fill;
            ibOld.Location = new Point(0, 46);
            ibOld.Name = "ibOld";
            ibOld.Size = new Size(380, 901);
            ibOld.TabIndex = 3;
            ibOld.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 46);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(26, 13);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 0;
            label2.Text = "Replaces Old Image";
            // 
            // lbNewName
            // 
            lbNewName.AutoSize = true;
            lbNewName.DataBindings.Add(new Binding("Text", bsMediaFile, "Name", true));
            lbNewName.Location = new Point(144, 21);
            lbNewName.Name = "lbNewName";
            lbNewName.Size = new Size(38, 15);
            lbNewName.TabIndex = 6;
            lbNewName.Text = "label3";
            // 
            // ImageCompareForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 947);
            Controls.Add(splitContainer1);
            Name = "ImageCompareForm";
            Text = "Image Compare Form";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ibNew).EndInit();
            pnLeftTop.ResumeLayout(false);
            pnLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsChoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMediaFile).EndInit();
            ((System.ComponentModel.ISupportInitialize)ibOld).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox ibNew;
        private Panel pnLeftTop;
        private Label label1;
        private PictureBox ibOld;
        private Panel panel1;
        private Label label2;
        private Button pbNext;
        private Button pbPrior;
        private CheckBox checkBox1;
        private BindingSource bsMediaFile;
        private Button pbApply;
        private ComboBox cbChoose;
        private ToolTip toolTip1;
        private BindingSource bsChoices;
        private Label lbNewName;
    }
}