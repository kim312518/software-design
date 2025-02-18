namespace WinFormsApp1.Tests
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public virtual string GetInfo()
        {
            return $"{Title} by {Author}";
        }
    }
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber}";
        }
    }
    public class Ebook : Book
    {
        public int FileSizeMB { get; set; }

        public override string GetInfo()
        {
            return $"{Title} (Ebook, {FileSizeMB}MB)";
        }
    }
}