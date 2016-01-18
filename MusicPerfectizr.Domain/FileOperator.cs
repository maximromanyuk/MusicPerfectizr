using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MusicPerfectizr.Domain
{
    public class FileOperator
    {
        private UserOptions _userOptions;
        public FileInfo CurrFile { get; set; }

        public FileOperator(UserOptions userOptions)
        {
            _userOptions = userOptions;
        }

        public void DoStuff()
        {
            //TODO: return boolean, too any attachments! Refactor it!
            
            string newFilePath = GetNewFilePath(GetNewTitle());

            if (File.Exists(newFilePath))
            {
                //untouchedCounter++;
                return;
            }

            if (_userOptions.MoveToNewFolder)
            {
                try
                {
                    File.Copy(CurrFile.FullName, newFilePath, true);
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
                File.SetAttributes(CurrFile.FullName, FileAttributes.Normal);
                File.Delete(CurrFile.FullName);
            }
        }

        public string GetNewTitle()
        {
            var taggedFile = TagLib.File.Create(CurrFile.FullName);
            string newTitle = CurrFile.Name;

            return GetNewTitle(taggedFile, ref newTitle);
        }

        public string GetNewTitle(TagLib.File taggedFile, 
            ref string newTitle)
        {
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
            else if (_userOptions.TitleMode == Title.ArtistTitle
                     && validTitle && !validPerformer)
            {
                newTitle = $"{title}.mp3";
            }
            else if (_userOptions.TitleMode == Title.ArtistTitle
                     && !validTitle && validPerformer)
            {
                //TODO: Think!
                newTitle = $"{performer} - {newTitle}.mp3";
            }
            else if (_userOptions.TitleMode == Title.JustTitle
                     && validTitle)
            {
                newTitle = $"{title}.mp3";
            }
            Console.WriteLine($", new title: {newTitle}");

            return newTitle;
        }

        public string GetNewFilePath(string title)
        {
            string filePath = "",
                   folder = _userOptions.MoveToNewFolder ?
                       _userOptions.SecondDirPath : CurrFile.DirectoryName;
            var taggedFile = TagLib.File.Create(CurrFile.FullName);

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
        public static string CleanString(string strIn)
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
