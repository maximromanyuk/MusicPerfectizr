namespace MusicPerfectizr.Domain
{
    public struct UserOptions
    {
        public UserOptions(Folding foldingMode, Title titleMode, bool moveToNewForder, bool newTags)
        {
            FoldingMode = foldingMode;
            TitleMode = titleMode;
            MoveToNewFolder = moveToNewForder;
            NewTags = newTags;
        }
        public Folding FoldingMode;
        public Title TitleMode;
        public bool MoveToNewFolder;
        public bool NewTags;
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