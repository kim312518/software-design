using System.Diagnostics;

namespace lab3__Task2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class BookObj
        {
            protected string Title;
            protected string Author;

            public BookObj(string title, string author)
            {
                Title = title;
                Author = author;
            }
            public abstract string GetInfo();
        }

        class Ebook : BookObj
        {
            private double FileSizeMB;
            public Ebook(string title, string author, double fileSize)
                 : base(title, author)
            {
                FileSizeMB = fileSize;
            }
            public override string GetInfo()
            {
                return $"E-Book: {Title} by {Author} | File Size: {FileSizeMB} MB";
            }
        }

        class PrintedBooks : BookObj
        {
            private int PageCount;

            public PrintedBooks(string title, string author, int pages)
                : base(title, author)
            {
                PageCount = pages;
            }

            public override string GetInfo()
            {
                return $"Printed Book: {Title} by {Author} | Pages: {PageCount}";
            }
        }

        class Magazine : BookObj
        {
            private int PageCount;

            public Magazine(string title, string author, int pages)
                : base(title, author)
            {
                PageCount = pages;
            }

            public override string GetInfo()
            {
                return $"Magazine: {Title} by {Author} | Pages: {PageCount}";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            BookObj[] books = new BookObj[]
            {
                new Ebook("C# Fundamentals", "John Doe", 5.2),
                new PrintedBooks("The Art of Programming", "Jane Smith", 350),
                new Ebook("Learn ASP.NET", "Alice Brown", 3.8),
                new Magazine("Victoria Secret Spring 1998", "Maery June", 54),
                new PrintedBooks("Cosmos", "Carl Sagan", 1150),
                new Magazine("Southeast Asian Food", "Cheery Lou", 35),

            };
            foreach (BookObj book in books)
            {
                listBox1.Items.Add(book.GetInfo());
            }
        }

      
    }
}
