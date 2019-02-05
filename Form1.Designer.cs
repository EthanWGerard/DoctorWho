namespace Lab5A
{
    partial class CompanionGroupBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanionGroupBox));
            this.DoctorGroupBox = new System.Windows.Forms.GroupBox();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.FirstEpisodeTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.SeriesTextBox = new System.Windows.Forms.TextBox();
            this.PlayedByTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.FirstEpisodeLabel = new System.Windows.Forms.Label();
            this.SeriesLabel = new System.Windows.Forms.Label();
            this.PlayedByLabel = new System.Windows.Forms.Label();
            this.DoctorLabel = new System.Windows.Forms.Label();
            this.companionsGroupBox = new System.Windows.Forms.GroupBox();
            this.companionListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DoctorGroupBox.SuspendLayout();
            this.companionsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorGroupBox
            // 
            this.DoctorGroupBox.Controls.Add(this.DoctorComboBox);
            this.DoctorGroupBox.Controls.Add(this.FirstEpisodeTextBox);
            this.DoctorGroupBox.Controls.Add(this.AgeTextBox);
            this.DoctorGroupBox.Controls.Add(this.SeriesTextBox);
            this.DoctorGroupBox.Controls.Add(this.PlayedByTextBox);
            this.DoctorGroupBox.Controls.Add(this.YearTextBox);
            this.DoctorGroupBox.Controls.Add(this.AgeLabel);
            this.DoctorGroupBox.Controls.Add(this.FirstEpisodeLabel);
            this.DoctorGroupBox.Controls.Add(this.SeriesLabel);
            this.DoctorGroupBox.Controls.Add(this.PlayedByLabel);
            this.DoctorGroupBox.Controls.Add(this.DoctorLabel);
            this.DoctorGroupBox.Location = new System.Drawing.Point(460, 67);
            this.DoctorGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoctorGroupBox.Name = "DoctorGroupBox";
            this.DoctorGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoctorGroupBox.Size = new System.Drawing.Size(231, 154);
            this.DoctorGroupBox.TabIndex = 0;
            this.DoctorGroupBox.TabStop = false;
            this.DoctorGroupBox.Text = "The Doctor";
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth",
            "Sixth",
            "Seventh",
            "Eighth",
            "Ninth",
            "Tenth",
            "Eleventh",
            "Twelfth"});
            this.DoctorComboBox.Location = new System.Drawing.Point(64, 27);
            this.DoctorComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(62, 21);
            this.DoctorComboBox.TabIndex = 9;
            this.DoctorComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FirstEpisodeTextBox
            // 
            this.FirstEpisodeTextBox.Location = new System.Drawing.Point(22, 122);
            this.FirstEpisodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstEpisodeTextBox.Name = "FirstEpisodeTextBox";
            this.FirstEpisodeTextBox.ReadOnly = true;
            this.FirstEpisodeTextBox.Size = new System.Drawing.Size(165, 20);
            this.FirstEpisodeTextBox.TabIndex = 6;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(163, 75);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.ReadOnly = true;
            this.AgeTextBox.Size = new System.Drawing.Size(25, 20);
            this.AgeTextBox.TabIndex = 8;
            // 
            // SeriesTextBox
            // 
            this.SeriesTextBox.Location = new System.Drawing.Point(64, 75);
            this.SeriesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SeriesTextBox.Name = "SeriesTextBox";
            this.SeriesTextBox.ReadOnly = true;
            this.SeriesTextBox.Size = new System.Drawing.Size(26, 20);
            this.SeriesTextBox.TabIndex = 7;
            // 
            // PlayedByTextBox
            // 
            this.PlayedByTextBox.Location = new System.Drawing.Point(81, 52);
            this.PlayedByTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlayedByTextBox.Name = "PlayedByTextBox";
            this.PlayedByTextBox.ReadOnly = true;
            this.PlayedByTextBox.Size = new System.Drawing.Size(107, 20);
            this.PlayedByTextBox.TabIndex = 6;
            this.PlayedByTextBox.TextChanged += new System.EventHandler(this.PlayedByTextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(141, 29);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.ReadOnly = true;
            this.YearTextBox.Size = new System.Drawing.Size(47, 20);
            this.YearTextBox.TabIndex = 5;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(94, 76);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(64, 13);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "Age at start:";
            // 
            // FirstEpisodeLabel
            // 
            this.FirstEpisodeLabel.AutoSize = true;
            this.FirstEpisodeLabel.Location = new System.Drawing.Point(20, 106);
            this.FirstEpisodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstEpisodeLabel.Name = "FirstEpisodeLabel";
            this.FirstEpisodeLabel.Size = new System.Drawing.Size(82, 13);
            this.FirstEpisodeLabel.TabIndex = 3;
            this.FirstEpisodeLabel.Text = "First full episode";
            // 
            // SeriesLabel
            // 
            this.SeriesLabel.AutoSize = true;
            this.SeriesLabel.Location = new System.Drawing.Point(21, 76);
            this.SeriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeriesLabel.Name = "SeriesLabel";
            this.SeriesLabel.Size = new System.Drawing.Size(39, 13);
            this.SeriesLabel.TabIndex = 2;
            this.SeriesLabel.Text = "Series:";
            this.SeriesLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PlayedByLabel
            // 
            this.PlayedByLabel.AutoSize = true;
            this.PlayedByLabel.Location = new System.Drawing.Point(21, 54);
            this.PlayedByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayedByLabel.Name = "PlayedByLabel";
            this.PlayedByLabel.Size = new System.Drawing.Size(56, 13);
            this.PlayedByLabel.TabIndex = 1;
            this.PlayedByLabel.Text = "Played by:";
            // 
            // DoctorLabel
            // 
            this.DoctorLabel.AutoSize = true;
            this.DoctorLabel.Location = new System.Drawing.Point(21, 29);
            this.DoctorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DoctorLabel.Name = "DoctorLabel";
            this.DoctorLabel.Size = new System.Drawing.Size(42, 13);
            this.DoctorLabel.TabIndex = 0;
            this.DoctorLabel.Text = "Doctor:";
            // 
            // companionsGroupBox
            // 
            this.companionsGroupBox.Controls.Add(this.companionListBox);
            this.companionsGroupBox.Location = new System.Drawing.Point(460, 256);
            this.companionsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.companionsGroupBox.Name = "companionsGroupBox";
            this.companionsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.companionsGroupBox.Size = new System.Drawing.Size(261, 311);
            this.companionsGroupBox.TabIndex = 1;
            this.companionsGroupBox.TabStop = false;
            this.companionsGroupBox.Text = "Companions and their first episode with this Doctor:";
            // 
            // companionListBox
            // 
            this.companionListBox.FormattingEnabled = true;
            this.companionListBox.Location = new System.Drawing.Point(4, 32);
            this.companionListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.companionListBox.Name = "companionListBox";
            this.companionListBox.Size = new System.Drawing.Size(253, 264);
            this.companionListBox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "F&ile";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 511);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CompanionGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.companionsGroupBox);
            this.Controls.Add(this.DoctorGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CompanionGroupBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CompanionGroupBox_Load);
            this.DoctorGroupBox.ResumeLayout(false);
            this.DoctorGroupBox.PerformLayout();
            this.companionsGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DoctorGroupBox;
        private System.Windows.Forms.Label SeriesLabel;
        private System.Windows.Forms.Label PlayedByLabel;
        private System.Windows.Forms.Label DoctorLabel;
        private System.Windows.Forms.GroupBox companionsGroupBox;
        private System.Windows.Forms.Label FirstEpisodeLabel;
        private System.Windows.Forms.TextBox FirstEpisodeTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox SeriesTextBox;
        private System.Windows.Forms.TextBox PlayedByTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox companionListBox;
    }
}

