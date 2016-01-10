using System;
using System.Windows.Forms;
using System.IO;
using MusicPerfectizr.Domain;

namespace MusicPerfectizr.FormsUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            moveToFolderCheckBox.CheckedChanged += EnableFields;

            folderBrowserDialog1.Description = "Choose folder with music...";
            pathToCopyTextBox.Enabled = false;
            chooseSecondDirectoryBtn.Enabled = false;
        }

        private void chooseDirectoryBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void chooseSecondDirectoryBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                pathToCopyTextBox.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.SelectedPath == "")
            {
                MessageBox.Show("Choose path");
                return;
            }

            var userOptions = new UserOptions(GetFolding(), GetTitle(),
                                              moveToFolderCheckBox.Checked);
            string secondDirPath = null;
            try
            {
                var dir = new DirectoryInfo(folderBrowserDialog2.SelectedPath);
                secondDirPath = dir.FullName;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: folderBrowserDialog2 don`t entered");
            }
            var mp3Files = new DirectoryInfo(folderBrowserDialog1.SelectedPath)
                .GetFiles("*.mp3", SearchOption.AllDirectories);
            var fileOperator = new FileOperator(mp3Files,
                                                userOptions,
                                                secondDirPath);

            fileOperator.DoStuff();
            
            MessageBox.Show("All done! We did it!");
        }

        private Folding GetFolding()
        {
            var temp = Folding.AsIs;
            if (createFoldingRadioButton.Checked)
                temp = Folding.CreateFolding;
            else if (allMusicToOneFolderRadioButton.Checked)
                temp = Folding.AllMusicToOneFolder;
            return temp;
        }

        private Title GetTitle()
        {
            var temp = Title.AsIs;
            if (artistTitleRadioButton.Checked)
                temp = Title.ArtistTitle;
            else if (titleRadioButton.Checked)
                temp = Title.JustTitle;
            return temp;
        }

        //CheckedChanged ivent for moveToFolderCheckBox
        private void EnableFields(object sender, EventArgs e)
        {
            pathToCopyTextBox.Enabled = !pathToCopyTextBox.Enabled;
            chooseSecondDirectoryBtn.Enabled = !chooseSecondDirectoryBtn.Enabled;
        }
    }
}
