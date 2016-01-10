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
            this.titleAsIsRadioButton = new System.Windows.Forms.RadioButton();
            this.artistTitleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.titleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createFoldingRadioButton = new System.Windows.Forms.RadioButton();
            this.doAnythingRadioButton = new System.Windows.Forms.RadioButton();
            this.allMusicToOneFolderRadioButton = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.moveToFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.chooseSecondDirectoryBtn = new System.Windows.Forms.Button();
            this.pathToCopyTextBox = new System.Windows.Forms.TextBox();
            this.enterPathLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.chooseDirectoryBtn = new System.Windows.Forms.Button();
            this.launchBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleAsIsRadioButton
            // 
            this.titleAsIsRadioButton.AutoSize = true;
            this.titleAsIsRadioButton.Checked = true;
            this.titleAsIsRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titleAsIsRadioButton.Location = new System.Drawing.Point(6, 68);
            this.titleAsIsRadioButton.Name = "titleAsIsRadioButton";
            this.titleAsIsRadioButton.Size = new System.Drawing.Size(48, 17);
            this.titleAsIsRadioButton.TabIndex = 2;
            this.titleAsIsRadioButton.TabStop = true;
            this.titleAsIsRadioButton.Text = "As Is";
            this.titleAsIsRadioButton.UseVisualStyleBackColor = true;
            // 
            // artistTitleRadioButton
            // 
            this.artistTitleRadioButton.AutoSize = true;
            this.artistTitleRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.artistTitleRadioButton.Location = new System.Drawing.Point(6, 22);
            this.artistTitleRadioButton.Name = "artistTitleRadioButton";
            this.artistTitleRadioButton.Size = new System.Drawing.Size(100, 17);
            this.artistTitleRadioButton.TabIndex = 0;
            this.artistTitleRadioButton.TabStop = true;
            this.artistTitleRadioButton.Text = "\"Artist\" - \"Title\" ";
            this.artistTitleRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.titleAsIsRadioButton);
            this.groupBox2.Controls.Add(this.titleRadioButton);
            this.groupBox2.Controls.Add(this.artistTitleRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(215, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 90);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New file name";
            // 
            // titleRadioButton
            // 
            this.titleRadioButton.AutoSize = true;
            this.titleRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titleRadioButton.Location = new System.Drawing.Point(6, 45);
            this.titleRadioButton.Name = "titleRadioButton";
            this.titleRadioButton.Size = new System.Drawing.Size(55, 17);
            this.titleRadioButton.TabIndex = 1;
            this.titleRadioButton.TabStop = true;
            this.titleRadioButton.Text = "\"Title\"";
            this.titleRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createFoldingRadioButton);
            this.groupBox1.Controls.Add(this.doAnythingRadioButton);
            this.groupBox1.Controls.Add(this.allMusicToOneFolderRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(20, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 90);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folding";
            // 
            // createFoldingRadioButton
            // 
            this.createFoldingRadioButton.AutoSize = true;
            this.createFoldingRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createFoldingRadioButton.Location = new System.Drawing.Point(6, 22);
            this.createFoldingRadioButton.Name = "createFoldingRadioButton";
            this.createFoldingRadioButton.Size = new System.Drawing.Size(168, 17);
            this.createFoldingRadioButton.TabIndex = 2;
            this.createFoldingRadioButton.Text = "Folding like \"Artist\" -> \"Album\"";
            this.createFoldingRadioButton.UseVisualStyleBackColor = true;
            // 
            // doAnythingRadioButton
            // 
            this.doAnythingRadioButton.AutoSize = true;
            this.doAnythingRadioButton.Checked = true;
            this.doAnythingRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.doAnythingRadioButton.Location = new System.Drawing.Point(6, 67);
            this.doAnythingRadioButton.Name = "doAnythingRadioButton";
            this.doAnythingRadioButton.Size = new System.Drawing.Size(48, 17);
            this.doAnythingRadioButton.TabIndex = 3;
            this.doAnythingRadioButton.TabStop = true;
            this.doAnythingRadioButton.Text = "As Is";
            this.doAnythingRadioButton.UseVisualStyleBackColor = true;
            // 
            // allMusicToOneFolderRadioButton
            // 
            this.allMusicToOneFolderRadioButton.AutoSize = true;
            this.allMusicToOneFolderRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allMusicToOneFolderRadioButton.Location = new System.Drawing.Point(6, 45);
            this.allMusicToOneFolderRadioButton.Name = "allMusicToOneFolderRadioButton";
            this.allMusicToOneFolderRadioButton.Size = new System.Drawing.Size(128, 17);
            this.allMusicToOneFolderRadioButton.TabIndex = 4;
            this.allMusicToOneFolderRadioButton.Text = "All music to one folder";
            this.allMusicToOneFolderRadioButton.UseVisualStyleBackColor = true;
            // 
            // moveToFolderCheckBox
            // 
            this.moveToFolderCheckBox.AutoSize = true;
            this.moveToFolderCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.moveToFolderCheckBox.Location = new System.Drawing.Point(20, 79);
            this.moveToFolderCheckBox.Name = "moveToFolderCheckBox";
            this.moveToFolderCheckBox.Size = new System.Drawing.Size(141, 17);
            this.moveToFolderCheckBox.TabIndex = 24;
            this.moveToFolderCheckBox.Text = "copy music to new foder";
            this.moveToFolderCheckBox.UseVisualStyleBackColor = true;
            this.moveToFolderCheckBox.CheckedChanged += new System.EventHandler(this.EnableFields);
            // 
            // chooseSecondDirectoryBtn
            // 
            this.chooseSecondDirectoryBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chooseSecondDirectoryBtn.Location = new System.Drawing.Point(313, 101);
            this.chooseSecondDirectoryBtn.Name = "chooseSecondDirectoryBtn";
            this.chooseSecondDirectoryBtn.Size = new System.Drawing.Size(25, 19);
            this.chooseSecondDirectoryBtn.TabIndex = 23;
            this.chooseSecondDirectoryBtn.Text = "...";
            this.chooseSecondDirectoryBtn.UseVisualStyleBackColor = true;
            this.chooseSecondDirectoryBtn.Click += new System.EventHandler(this.chooseSecondDirectoryBtn_Click);
            // 
            // pathToCopyTextBox
            // 
            this.pathToCopyTextBox.Location = new System.Drawing.Point(20, 101);
            this.pathToCopyTextBox.Name = "pathToCopyTextBox";
            this.pathToCopyTextBox.Size = new System.Drawing.Size(287, 20);
            this.pathToCopyTextBox.TabIndex = 22;
            // 
            // enterPathLabel
            // 
            this.enterPathLabel.AutoSize = true;
            this.enterPathLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.enterPathLabel.Location = new System.Drawing.Point(17, 17);
            this.enterPathLabel.Name = "enterPathLabel";
            this.enterPathLabel.Size = new System.Drawing.Size(70, 13);
            this.enterPathLabel.TabIndex = 21;
            this.enterPathLabel.Text = "Choose path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(20, 32);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(287, 20);
            this.pathTextBox.TabIndex = 20;
            // 
            // chooseDirectoryBtn
            // 
            this.chooseDirectoryBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chooseDirectoryBtn.Location = new System.Drawing.Point(313, 32);
            this.chooseDirectoryBtn.Name = "chooseDirectoryBtn";
            this.chooseDirectoryBtn.Size = new System.Drawing.Size(25, 20);
            this.chooseDirectoryBtn.TabIndex = 19;
            this.chooseDirectoryBtn.Text = "...";
            this.chooseDirectoryBtn.UseVisualStyleBackColor = true;
            this.chooseDirectoryBtn.Click += new System.EventHandler(this.chooseDirectoryBtn_Click);
            // 
            // launchBtn
            // 
            this.launchBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.launchBtn.Location = new System.Drawing.Point(97, 264);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(172, 30);
            this.launchBtn.TabIndex = 18;
            this.launchBtn.Text = "Launch!";
            this.launchBtn.UseVisualStyleBackColor = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.moveToFolderCheckBox);
            this.Controls.Add(this.chooseSecondDirectoryBtn);
            this.Controls.Add(this.pathToCopyTextBox);
            this.Controls.Add(this.enterPathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.chooseDirectoryBtn);
            this.Controls.Add(this.launchBtn);
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

        private System.Windows.Forms.RadioButton titleAsIsRadioButton;
        private System.Windows.Forms.RadioButton artistTitleRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton titleRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton createFoldingRadioButton;
        private System.Windows.Forms.RadioButton doAnythingRadioButton;
        private System.Windows.Forms.RadioButton allMusicToOneFolderRadioButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.CheckBox moveToFolderCheckBox;
        private System.Windows.Forms.Button chooseSecondDirectoryBtn;
        private System.Windows.Forms.TextBox pathToCopyTextBox;
        private System.Windows.Forms.Label enterPathLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button chooseDirectoryBtn;
        private System.Windows.Forms.Button launchBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

