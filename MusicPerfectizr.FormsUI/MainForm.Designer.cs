namespace MusicPerfectizr.FormsUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.artistTitleRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.titleRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.titleAsIsRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doAnythingRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.createFoldingRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.allMusicToOneFolderRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.enterPathLabel = new MetroFramework.Controls.MetroLabel();
            this.pathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.chooseDirectoryBtn = new MetroFramework.Controls.MetroButton();
            this.chooseSecondDirectoryBtn = new MetroFramework.Controls.MetroButton();
            this.pathToCopyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.moveToFolderCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.launchBtn = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.artistTitleRadioButton);
            this.groupBox2.Controls.Add(this.titleRadioButton);
            this.groupBox2.Controls.Add(this.titleAsIsRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(226, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 90);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New file name";
            // 
            // artistTitleRadioButton
            // 
            this.artistTitleRadioButton.AutoSize = true;
            this.artistTitleRadioButton.Location = new System.Drawing.Point(9, 24);
            this.artistTitleRadioButton.Name = "artistTitleRadioButton";
            this.artistTitleRadioButton.Size = new System.Drawing.Size(108, 15);
            this.artistTitleRadioButton.TabIndex = 5;
            this.artistTitleRadioButton.Text = "\"Artist\" - \"Title\" ";
            this.artistTitleRadioButton.UseVisualStyleBackColor = true;
            // 
            // titleRadioButton
            // 
            this.titleRadioButton.AutoSize = true;
            this.titleRadioButton.Location = new System.Drawing.Point(9, 45);
            this.titleRadioButton.Name = "titleRadioButton";
            this.titleRadioButton.Size = new System.Drawing.Size(56, 15);
            this.titleRadioButton.TabIndex = 6;
            this.titleRadioButton.Text = "\"Title\"";
            this.titleRadioButton.UseVisualStyleBackColor = true;
            // 
            // titleAsIsRadioButton
            // 
            this.titleAsIsRadioButton.AutoSize = true;
            this.titleAsIsRadioButton.Checked = true;
            this.titleAsIsRadioButton.Location = new System.Drawing.Point(9, 66);
            this.titleAsIsRadioButton.Name = "titleAsIsRadioButton";
            this.titleAsIsRadioButton.Size = new System.Drawing.Size(47, 15);
            this.titleAsIsRadioButton.TabIndex = 7;
            this.titleAsIsRadioButton.TabStop = true;
            this.titleAsIsRadioButton.Text = "As Is";
            this.titleAsIsRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doAnythingRadioButton);
            this.groupBox1.Controls.Add(this.createFoldingRadioButton);
            this.groupBox1.Controls.Add(this.allMusicToOneFolderRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(20, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folding";
            // 
            // doAnythingRadioButton
            // 
            this.doAnythingRadioButton.AutoSize = true;
            this.doAnythingRadioButton.Checked = true;
            this.doAnythingRadioButton.Location = new System.Drawing.Point(6, 61);
            this.doAnythingRadioButton.Name = "doAnythingRadioButton";
            this.doAnythingRadioButton.Size = new System.Drawing.Size(47, 15);
            this.doAnythingRadioButton.TabIndex = 4;
            this.doAnythingRadioButton.TabStop = true;
            this.doAnythingRadioButton.Text = "As Is";
            this.doAnythingRadioButton.UseVisualStyleBackColor = true;
            // 
            // createFoldingRadioButton
            // 
            this.createFoldingRadioButton.AutoSize = true;
            this.createFoldingRadioButton.Location = new System.Drawing.Point(5, 19);
            this.createFoldingRadioButton.Name = "createFoldingRadioButton";
            this.createFoldingRadioButton.Size = new System.Drawing.Size(190, 15);
            this.createFoldingRadioButton.TabIndex = 2;
            this.createFoldingRadioButton.Text = "Folding like \"Artist\" -> \"Album\"";
            this.createFoldingRadioButton.UseVisualStyleBackColor = true;
            // 
            // allMusicToOneFolderRadioButton
            // 
            this.allMusicToOneFolderRadioButton.AutoSize = true;
            this.allMusicToOneFolderRadioButton.Location = new System.Drawing.Point(6, 40);
            this.allMusicToOneFolderRadioButton.Name = "allMusicToOneFolderRadioButton";
            this.allMusicToOneFolderRadioButton.Size = new System.Drawing.Size(143, 15);
            this.allMusicToOneFolderRadioButton.TabIndex = 3;
            this.allMusicToOneFolderRadioButton.Text = "All music to one folder";
            this.allMusicToOneFolderRadioButton.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // enterPathLabel
            // 
            this.enterPathLabel.AutoSize = true;
            this.enterPathLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.enterPathLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.enterPathLabel.Location = new System.Drawing.Point(17, 17);
            this.enterPathLabel.Name = "enterPathLabel";
            this.enterPathLabel.Size = new System.Drawing.Size(77, 15);
            this.enterPathLabel.TabIndex = 28;
            this.enterPathLabel.Text = "Choose path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(20, 32);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(298, 20);
            this.pathTextBox.TabIndex = 29;
            // 
            // chooseDirectoryBtn
            // 
            this.chooseDirectoryBtn.Location = new System.Drawing.Point(324, 32);
            this.chooseDirectoryBtn.Name = "chooseDirectoryBtn";
            this.chooseDirectoryBtn.Size = new System.Drawing.Size(25, 20);
            this.chooseDirectoryBtn.TabIndex = 30;
            this.chooseDirectoryBtn.Text = "...";
            this.chooseDirectoryBtn.Click += new System.EventHandler(this.chooseDirectoryBtn_Click);
            // 
            // chooseSecondDirectoryBtn
            // 
            this.chooseSecondDirectoryBtn.Location = new System.Drawing.Point(324, 96);
            this.chooseSecondDirectoryBtn.Name = "chooseSecondDirectoryBtn";
            this.chooseSecondDirectoryBtn.Size = new System.Drawing.Size(25, 20);
            this.chooseSecondDirectoryBtn.TabIndex = 31;
            this.chooseSecondDirectoryBtn.Text = "...";
            this.chooseSecondDirectoryBtn.Click += new System.EventHandler(this.chooseSecondDirectoryBtn_Click);
            // 
            // pathToCopyTextBox
            // 
            this.pathToCopyTextBox.Location = new System.Drawing.Point(20, 96);
            this.pathToCopyTextBox.Name = "pathToCopyTextBox";
            this.pathToCopyTextBox.Size = new System.Drawing.Size(298, 20);
            this.pathToCopyTextBox.TabIndex = 32;
            // 
            // moveToFolderCheckBox
            // 
            this.moveToFolderCheckBox.AutoSize = true;
            this.moveToFolderCheckBox.Location = new System.Drawing.Point(20, 75);
            this.moveToFolderCheckBox.Name = "moveToFolderCheckBox";
            this.moveToFolderCheckBox.Size = new System.Drawing.Size(157, 15);
            this.moveToFolderCheckBox.TabIndex = 33;
            this.moveToFolderCheckBox.Text = "copy music to new folder";
            this.moveToFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 242);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(329, 20);
            this.progressBar1.TabIndex = 36;
            // 
            // launchBtn
            // 
            this.launchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.launchBtn.Highlight = true;
            this.launchBtn.Location = new System.Drawing.Point(100, 270);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(170, 30);
            this.launchBtn.TabIndex = 37;
            this.launchBtn.Text = "Launch!";
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(372, 314);
            this.Controls.Add(this.launchBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.moveToFolderCheckBox);
            this.Controls.Add(this.pathToCopyTextBox);
            this.Controls.Add(this.chooseSecondDirectoryBtn);
            this.Controls.Add(this.chooseDirectoryBtn);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.enterPathLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Perfectizr";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel enterPathLabel;
        private MetroFramework.Controls.MetroTextBox pathTextBox;
        private MetroFramework.Controls.MetroButton chooseDirectoryBtn;
        private MetroFramework.Controls.MetroButton chooseSecondDirectoryBtn;
        private MetroFramework.Controls.MetroTextBox pathToCopyTextBox;
        private MetroFramework.Controls.MetroCheckBox moveToFolderCheckBox;
        private MetroFramework.Controls.MetroRadioButton doAnythingRadioButton;
        private MetroFramework.Controls.MetroRadioButton allMusicToOneFolderRadioButton;
        private MetroFramework.Controls.MetroRadioButton createFoldingRadioButton;
        private MetroFramework.Controls.MetroRadioButton titleAsIsRadioButton;
        private MetroFramework.Controls.MetroRadioButton titleRadioButton;
        private MetroFramework.Controls.MetroRadioButton artistTitleRadioButton;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private MetroFramework.Controls.MetroButton launchBtn;
    }
}

