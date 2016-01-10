namespace MusicPerfectizr.Domain
{
    public struct UserOptions
    {
        public UserOptions(Folding foldingMode, Title titleMode, bool moveToNewForder)
        {
            FoldingMode = foldingMode;
            TitleMode = titleMode;
            MoveToNewFolder = moveToNewForder;
        }
        public Folding FoldingMode;
        public Title TitleMode;
        public bool MoveToNewFolder;
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