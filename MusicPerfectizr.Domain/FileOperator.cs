using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MusicPerfectizr.Domain
{
    public class FileOperator
    {
        private UserOptions _userOptions;
        private FileInfo _currFile;

        public FileOperator(UserOptions userOptions)
        {
            _userOptions = userOptions;
        }

        public void SetTarget(FileInfo file)
        {
            _currFile = file;
        }

        public void DoStuff()
        {
            string newFilePath = GetNewFilePath();

            if (File.Exists(newFilePath))
            {
                //untouchedCounter++;
                return;
            }

            if (_userOptions.MoveToNewFolder)
            {
                try
                {
                    File.Copy(_currFile.FullName, newFilePath, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"----- When copy: sourse: {ex.Source}, Message: {ex.Message}");
                    //exceptionCounter++;
                }
            }
            else
            {
                // delete file, if we don`t move it to another folder
                File.SetAttributes(_currFile.FullName, FileAttributes.Normal);
                File.Delete(_currFile.FullName);
            }
        }

        private string GetNewTitle(TagLib.File taggedFile)
        {
            string newTitle = _currFile.Name;
            string performer = CleanString(taggedFile.Tag.FirstPerformer),
                   title = CleanString(taggedFile.Tag.Title);

            bool validTitle = !string.IsNullOrEmpty(taggedFile.Tag.Title),
                 validPerformer = !string.IsNullOrEmpty(taggedFile.Tag.FirstPerformer);

            Console.Write($"----- Start title: {newTitle}");
            if (_userOptions.TitleMode == Title.ArtistTitle
                     && validTitle && validPerformer)
            {
                newTitle = $"{performer} - {title}.mp3";
            }
            else if (_userOptions.TitleMode == Title.JustTitle
                     && validTitle)
            {
                newTitle = $"{title}.mp3";
            }
            Console.WriteLine($", new title: {newTitle}");

            return newTitle;
        }

        private string GetNewFilePath()
        {
            var taggedFile = TagLib.File.Create(_currFile.FullName);

            string folder = _userOptions.MoveToNewFolder ?
                       _userOptions.SecondDirPath : _currFile.DirectoryName;

            string title = GetNewTitle(taggedFile),
                   filePath = "";
            switch (_userOptions.FoldingMode)
            {
                case Folding.AsIs:
                    filePath = Directory.CreateDirectory(folder).FullName + "\\" + title;
                    break;

                case Folding.AllMusicToOneFolder:
                    filePath = Directory.CreateDirectory($"{folder}\\All music here\\")
                        .FullName + "\\" + title;
                    break;

                case Folding.CreateFolding:
                    string performer = taggedFile.Tag.FirstPerformer,
                           album = taggedFile.Tag.Album;

                    if (!string.IsNullOrEmpty(performer) &&
                        !string.IsNullOrEmpty(album))
                    {
                        filePath = Directory.CreateDirectory($"{folder}\\Sorted music\\{performer}\\{album}")
                            .FullName + "\\" + title;
                    }
                    else
                    {
                        // TODO: file with valid performers and albums to separate folders
                        filePath = $"{folder}\\Sorted music\\Files without album or artist\\{title}";
                    }
                    break;
            }
            Console.WriteLine($"----- New file path: {filePath}\n");
            return filePath;
        }
        // returns string without invalid characters
        private static string CleanString(string strIn)
        {
            if (string.IsNullOrEmpty(strIn))
                return strIn;
            try
            {
                return Regex.Replace(strIn, @"[^\w\.\&(),^%$#~{}`\[\]\'@-]", " ", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                //TODO: Danger!
                return string.Empty;
            }
        }
    }
}
