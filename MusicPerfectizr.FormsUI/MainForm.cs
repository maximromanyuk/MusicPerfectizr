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

            // upgrade: пошук файлів виходячи з теперішнього імені файлу
            LastFMcheckBox.Enabled = false;
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

            var userOptions = new UserOptions(Folding(), Title(),
                                              moveToFolderCheckBox.Checked,
                                              LastFMcheckBox.Checked);
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

            if (LastFMcheckBox.Checked)
                fileOperator.AddNewTags();

            fileOperator.DoStuff();
            MessageBox.Show("All done! We did it!");
        }

        private Folding Folding()
        {
            var temp = Domain.Folding.AsIs;
            if (createFoldingRadioButton.Checked)
                temp = Domain.Folding.CreateFolding;
            else if (allMusicToOneFolderRadioButton.Checked)
                temp = Domain.Folding.AllMusicToOneFolder;
            return temp;
        }

        private Title Title()
        {
            var temp = Domain.Title.AsIs;
            if (artistTitleRadioButton.Checked)
                temp = Domain.Title.ArtistTitle;
            else if (titleRadioButton.Checked)
                temp = Domain.Title.JustTitle;
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
