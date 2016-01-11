using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MusicPerfectizr.Domain
{
    public class FileOperator
    {
        private UserOptions _userOptions;

        public FileOperator(UserOptions userOptions)
        {
            _userOptions = userOptions;
        }

        public void DoStuff(FileInfo file)
        {
            // TODO: Повертати boolean, забагато вкладень!!!
            
            string newFilePath = GetNewFilePath(file, GetNewTitle(file));

            if (File.Exists(newFilePath))
            {
                //untouchedCounter++;
                return;
            }

            if (_userOptions.MoveToNewFolder)
            {
                try
                {
                    File.Copy(file.FullName, newFilePath, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"----- When copy: sourse: {ex.Source}, Message: {ex.Message}");
                    //exceptionCounter++;
                }
            }
            else
            {
                // видалити якщо не переміщуємо файл в іншу папку
                File.SetAttributes(file.FullName, FileAttributes.Normal);
                File.Delete(file.FullName);
            }
        }

        public string GetNewTitle(FileInfo file)
        {
            var taggedFile = TagLib.File.Create(file.FullName);
            string temp = file.Name;

            return GetNewTitle(taggedFile, ref temp);
        }

        public string GetNewTitle(TagLib.File taggedFile, 
            ref string temp)
        {
            string performer = CleanString(taggedFile.Tag.FirstPerformer),
                title = CleanString(taggedFile.Tag.Title);
            bool validTitle = !string.IsNullOrEmpty(taggedFile.Tag.Title),
                validPerformer = !string.IsNullOrEmpty(taggedFile.Tag.FirstPerformer);

            Console.Write($"----- Start title: {temp}");
            if (_userOptions.TitleMode == Title.ArtistTitle
                && validTitle && validPerformer)
            {
                temp = $"{performer} - {title}.mp3";
            }
            else if (_userOptions.TitleMode == Title.ArtistTitle
                     && validTitle && !validPerformer)
            {
                temp = $"{title}.mp3";
            }
            else if (_userOptions.TitleMode == Title.ArtistTitle
                     && !validTitle && validPerformer)
            {
                // TODO: Think!
                temp = $"{performer} - {temp}.mp3";
            }
            else if (_userOptions.TitleMode == Title.JustTitle
                     && validTitle)
            {
                temp = $"{title}.mp3";
            }
            Console.WriteLine($", new title: {temp}");

            return temp;
        }

        public string GetNewFilePath(FileInfo file, string newTitle)
        {
            string temp = "",
                   folder = _userOptions.MoveToNewFolder ?
                       _userOptions.SecondDirPath : file.DirectoryName;
            var taggedFile = TagLib.File.Create(file.FullName);

            switch (_userOptions.FoldingMode)
            {
                case Folding.AsIs:
                    temp = Directory.CreateDirectory(folder).FullName + "\\" + newTitle;
                    break;

                case Folding.AllMusicToOneFolder:
                    temp = Directory.CreateDirectory($"{folder}\\All music here\\")
                        .FullName + "\\" + newTitle;
                    break;

                case Folding.CreateFolding:
                    string performer = taggedFile.Tag.FirstPerformer,
                           album = taggedFile.Tag.Album;

                    if (!string.IsNullOrEmpty(performer) &&
                        !string.IsNullOrEmpty(album))
                    {
                        temp = Directory.CreateDirectory($"{folder}\\Sorted music\\{performer}\\{album}")
                            .FullName + "\\" + newTitle;
                    }
                    else
                    {
                        // TODO: file with valid performers and albums to separate folders
                        temp = $"{folder}\\Sorted music\\Files without album or artist\\{newTitle}";
                    }
                    break;
            }
            Console.WriteLine($"----- New file path: {temp}\n");
            return temp;
        }
        // Повертає строку без недопустимих символів
        public static string CleanString(string strIn)
        {
            // якщо стрічка пуста - повертаємо її назад
            if (string.IsNullOrEmpty(strIn))
                return strIn;
            try
            {
                // заміняємо недопустимі символи пробілами
                return Regex.Replace(strIn, @"[^\w\.\&(),^%$#~{}`\[\]\'@-]", " ", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                // Danger!
                return string.Empty;
            }
        }
    }
}
