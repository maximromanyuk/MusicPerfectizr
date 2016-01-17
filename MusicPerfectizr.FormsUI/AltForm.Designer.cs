namespace MusicPerfectizr.FormsUI
{
    partial class AltForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltForm));
            this.launchBtn = new MetroFramework.Controls.MetroButton();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.moveToFolderCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.pathToCopyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.chooseSecondDirectoryBtn = new MetroFramework.Controls.MetroButton();
            this.chooseDirectoryBtn = new MetroFramework.Controls.MetroButton();
            this.pathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.enterPathLabel = new MetroFramework.Controls.MetroLabel();
            this.artistTitleRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.titleRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.titleAsIsRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.doAnythingRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.createFoldingRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.allMusicToOneFolderRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // launchBtn
            // 
            this.launchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.launchBtn.Highlight = true;
            this.launchBtn.Location = new System.Drawing.Point(93, 287);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(176, 30);
            this.launchBtn.TabIndex = 47;
            this.launchBtn.Text = "Launch!";
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 238);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(329, 20);
            this.progressBar1.TabIndex = 46;
            // 
            // moveToFolderCheckBox
            // 
            this.moveToFolderCheckBox.AutoSize = true;
            this.moveToFolderCheckBox.Location = new System.Drawing.Point(159, 150);
            this.moveToFolderCheckBox.Name = "moveToFolderCheckBox";
            this.moveToFolderCheckBox.Size = new System.Drawing.Size(157, 15);
            this.moveToFolderCheckBox.TabIndex = 45;
            this.moveToFolderCheckBox.Text = "copy music to new folder";
            this.moveToFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // pathToCopyTextBox
            // 
            this.pathToCopyTextBox.Location = new System.Drawing.Point(159, 171);
            this.pathToCopyTextBox.Name = "pathToCopyTextBox";
            this.pathToCopyTextBox.Size = new System.Drawing.Size(298, 20);
            this.pathToCopyTextBox.TabIndex = 44;
            // 
            // chooseSecondDirectoryBtn
            // 
            this.chooseSecondDirectoryBtn.Location = new System.Drawing.Point(463, 171);
            this.chooseSecondDirectoryBtn.Name = "chooseSecondDirectoryBtn";
            this.chooseSecondDirectoryBtn.Size = new System.Drawing.Size(25, 20);
            this.chooseSecondDirectoryBtn.TabIndex = 43;
            this.chooseSecondDirectoryBtn.Text = "...";
            this.chooseSecondDirectoryBtn.Click += new System.EventHandler(this.chooseSecondDirectoryBtn_Click);
            // 
            // chooseDirectoryBtn
            // 
            this.chooseDirectoryBtn.Highlight = true;
            this.chooseDirectoryBtn.Location = new System.Drawing.Point(321, 16);
            this.chooseDirectoryBtn.Name = "chooseDirectoryBtn";
            this.chooseDirectoryBtn.Size = new System.Drawing.Size(25, 20);
            this.chooseDirectoryBtn.TabIndex = 42;
            this.chooseDirectoryBtn.Text = "...";
            this.chooseDirectoryBtn.Click += new System.EventHandler(this.chooseDirectoryBtn_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pathTextBox.Location = new System.Drawing.Point(159, 107);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(298, 20);
            this.pathTextBox.TabIndex = 41;
            this.pathTextBox.UseStyleColors = true;
            // 
            // enterPathLabel
            // 
            this.enterPathLabel.AutoSize = true;
            this.enterPathLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.enterPathLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.enterPathLabel.Location = new System.Drawing.Point(156, 92);
            this.enterPathLabel.Name = "enterPathLabel";
            this.enterPathLabel.Size = new System.Drawing.Size(77, 15);
            this.enterPathLabel.TabIndex = 40;
            this.enterPathLabel.Text = "Choose path:";
            // 
            // artistTitleRadioButton
            // 
            this.artistTitleRadioButton.AutoSize = true;
            this.artistTitleRadioButton.Location = new System.Drawing.Point(5, 13);
            this.artistTitleRadioButton.Name = "artistTitleRadioButton";
            this.artistTitleRadioButton.Size = new System.Drawing.Size(108, 15);
            this.artistTitleRadioButton.TabIndex = 5;
            this.artistTitleRadioButton.Text = "\"Artist\" - \"Title\" ";
            this.artistTitleRadioButton.UseVisualStyleBackColor = true;
            // 
            // titleRadioButton
            // 
            this.titleRadioButton.AutoSize = true;
            this.titleRadioButton.Location = new System.Drawing.Point(5, 34);
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
            this.titleAsIsRadioButton.Location = new System.Drawing.Point(5, 55);
            this.titleAsIsRadioButton.Name = "titleAsIsRadioButton";
            this.titleAsIsRadioButton.Size = new System.Drawing.Size(47, 15);
            this.titleAsIsRadioButton.TabIndex = 7;
            this.titleAsIsRadioButton.TabStop = true;
            this.titleAsIsRadioButton.Text = "As Is";
            this.titleAsIsRadioButton.UseVisualStyleBackColor = true;
            // 
            // doAnythingRadioButton
            // 
            this.doAnythingRadioButton.AutoSize = true;
            this.doAnythingRadioButton.Checked = true;
            this.doAnythingRadioButton.Location = new System.Drawing.Point(6, 55);
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
            this.createFoldingRadioButton.Location = new System.Drawing.Point(6, 13);
            this.createFoldingRadioButton.Name = "createFoldingRadioButton";
            this.createFoldingRadioButton.Size = new System.Drawing.Size(190, 15);
            this.createFoldingRadioButton.TabIndex = 2;
            this.createFoldingRadioButton.Text = "Folding like \"Artist\" -> \"Album\"";
            this.createFoldingRadioButton.UseVisualStyleBackColor = true;
            // 
            // allMusicToOneFolderRadioButton
            // 
            this.allMusicToOneFolderRadioButton.AutoSize = true;
            this.allMusicToOneFolderRadioButton.Location = new System.Drawing.Point(6, 34);
            this.allMusicToOneFolderRadioButton.Name = "allMusicToOneFolderRadioButton";
            this.allMusicToOneFolderRadioButton.Size = new System.Drawing.Size(143, 15);
            this.allMusicToOneFolderRadioButton.TabIndex = 3;
            this.allMusicToOneFolderRadioButton.Text = "All music to one folder";
            this.allMusicToOneFolderRadioButton.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(223, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 15);
            this.metroLabel2.TabIndex = 53;
            this.metroLabel2.Text = "File name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(14, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 15);
            this.metroLabel1.TabIndex = 52;
            this.metroLabel1.Text = "Folding";
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.artistTitleRadioButton);
            this.metroPanel3.Controls.Add(this.titleRadioButton);
            this.metroPanel3.Controls.Add(this.titleAsIsRadioButton);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(223, 135);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(123, 77);
            this.metroPanel3.TabIndex = 51;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.doAnythingRadioButton);
            this.metroPanel2.Controls.Add(this.createFoldingRadioButton);
            this.metroPanel2.Controls.Add(this.allMusicToOneFolderRadioButton);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(14, 135);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(203, 77);
            this.metroPanel2.TabIndex = 48;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.launchBtn);
            this.metroPanel1.Controls.Add(this.progressBar1);
            this.metroPanel1.Controls.Add(this.chooseDirectoryBtn);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(142, 91);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(366, 343);
            this.metroPanel1.TabIndex = 48;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // AltForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 440);
            this.Controls.Add(this.moveToFolderCheckBox);
            this.Controls.Add(this.pathToCopyTextBox);
            this.Controls.Add(this.chooseSecondDirectoryBtn);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.enterPathLabel);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AltForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "Music Perfectizr";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton launchBtn;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private MetroFramework.Controls.MetroCheckBox moveToFolderCheckBox;
        private MetroFramework.Controls.MetroTextBox pathToCopyTextBox;
        private MetroFramework.Controls.MetroButton chooseSecondDirectoryBtn;
        private MetroFramework.Controls.MetroButton chooseDirectoryBtn;
        private MetroFramework.Controls.MetroTextBox pathTextBox;
        private MetroFramework.Controls.MetroLabel enterPathLabel;
        private MetroFramework.Controls.MetroRadioButton artistTitleRadioButton;
        private MetroFramework.Controls.MetroRadioButton titleRadioButton;
        private MetroFramework.Controls.MetroRadioButton titleAsIsRadioButton;
        private MetroFramework.Controls.MetroRadioButton doAnythingRadioButton;
        private MetroFramework.Controls.MetroRadioButton createFoldingRadioButton;
        private MetroFramework.Controls.MetroRadioButton allMusicToOneFolderRadioButton;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}