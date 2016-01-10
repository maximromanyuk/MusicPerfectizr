using System;
using System.IO;

namespace MusicPerfectizr.Domain
{
    public class FileOperator
    {
        private string _secondDirPath;
        private FileInfo[] _mp3Files;
        private UserOptions _userOptions;

        public FileOperator(FileInfo[] mp3Files,
                            UserOptions userOptions,
                            string secondDirPath)
        {
            _mp3Files = mp3Files;
            _userOptions = userOptions;
            _secondDirPath = secondDirPath;
        }

        public void DoStuff()
        {
            int exceptionCounter = 0,
                renamedCounter = 0,
                untouchedCounter = 0;

            foreach (var file in _mp3Files)
            {
                string newFilePath = "";
                // TODO: Повертати boolean
                newFilePath = GetNewFilePath(file, GetNewTitle(file, ref renamedCounter));

                if (File.Exists(newFilePath))
                {
                    untouchedCounter++;
                    continue;
                }

                //TODO: convert to System.IO.File.Replace
                try
                {
                    File.Copy(file.FullName, newFilePath, true);
                    File.SetAttributes(newFilePath, FileAttributes.Normal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"----- When copy: sourse: {ex.Source}, Message: {ex.Message}");
                    exceptionCounter++;
                    continue;
                }

                if (_userOptions.MoveToNewFolder) continue;
                // видалити якщо не переміщуємо файл в іншу папку
                File.SetAttributes(file.FullName, FileAttributes.Normal);
                File.Delete(file.FullName);
            }
            Console.WriteLine(
                $"----- Errors: {exceptionCounter}, Renamed files: {renamedCounter}, Untouched files: {untouchedCounter}");
        }

        public string GetNewTitle(FileInfo file, ref int renamedCounter)
        {
            var taggedFile = TagLib.File.Create(file.FullName);
            string temp = file.Name;

            return GetNewTitle(taggedFile, ref temp, ref renamedCounter);
        }

        public string GetNewTitle(TagLib.File taggedFile, 
            ref string temp, ref int renamedCounter)
        {
            string performer = Feature.CleanString(taggedFile.Tag.FirstPerformer),
                title = Feature.CleanString(taggedFile.Tag.Title);
            bool validTitle = !string.IsNullOrEmpty(taggedFile.Tag.Title),
                validPerformer = !string.IsNullOrEmpty(taggedFile.Tag.FirstPerformer);

            Console.Write($"----- Start title: {temp}");
            if (_userOptions.TitleMode == Title.ArtistTitle
                && validTitle && validPerformer)
            {
                temp = $"{performer} - {title}.mp3";
                renamedCounter++;
            }
            else if (_userOptions.TitleMode == Title.ArtistTitle
                     && validTitle && !validPerformer)
            {
                temp = $"{title}.mp3";
                renamedCounter++;
            }
            else if (_userOptions.TitleMode == Title.ArtistTitle
                     && !validTitle && validPerformer)
            {
                // TODO: Think!
                temp = $"{performer} - {temp}.mp3";
                renamedCounter++;
            }
            else if (_userOptions.TitleMode == Title.JustTitle
                     && validTitle)
            {
                temp = $"{title}.mp3";
                renamedCounter++;
            }
            Console.WriteLine($", new title: {temp}");

            return temp;
        }

        public string GetNewFilePath(FileInfo file, string newTitle)
        {
            string temp = "",
                   folder = _userOptions.MoveToNewFolder ?
                       _secondDirPath : file.DirectoryName;
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

        // TODO: не реалізовано
        public void AddNewTags()
        {
            // ignored
        }
    }
}
