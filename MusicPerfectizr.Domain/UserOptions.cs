namespace MusicPerfectizr.Domain
{
    // structure for transfer date between UI and Domain
    public struct UserOptions
    {
        public UserOptions(Folding foldingMode, Title titleMode, 
            bool moveToNewForder, string secondDirPath)
        {
            FoldingMode = foldingMode;
            TitleMode = titleMode;
            MoveToNewFolder = moveToNewForder;
            SecondDirPath = secondDirPath;
        }
        public Folding FoldingMode;
        public Title TitleMode;
        public bool MoveToNewFolder;
        public string SecondDirPath;
    }

    public enum Title
    {
        ArtistTitle,
        JustTitle,
        AsIs
    }

    public enum Folding
    {
        CreateFolding,
        AsIs,
        AllMusicToOneFolder
    }
}