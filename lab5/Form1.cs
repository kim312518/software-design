using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }

        }
        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }

            public virtual Author Author { get; set; }

        }
        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.Name == authorName);
                if (author == null)
                {
                    author = new Author { Name = authorName };
                    context.Authors.Add(author);
                }

                var book = new Book { Title = bookTitle, Author = author };
                context.Books.Add(book);
                context.SaveChanges();
            }
        }


        public List<string> GetBookWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var bookWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();

                return bookWithAuthors;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = GetBookWithAuthors();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully!");
        }
        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                DeleteBook(bookId);
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = GetBookWithAuthors();
            }
            else
            {
                MessageBox.Show("Invalid Book ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name == authorName)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text.Trim();
            if (!string.IsNullOrEmpty(authorName))
            {
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = SearchBooksByAuthor(authorName);
            }
            else
            {
                MessageBox.Show("Enter an author's name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text.Trim();
            string bookTitle = txtBookTitle.Text.Trim();

            if (!string.IsNullOrEmpty(authorName) && !string.IsNullOrEmpty(bookTitle))
            {
                AddAuthorWithBook(authorName, bookTitle);
                MessageBox.Show("Book and Author added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = GetBookWithAuthors();
            }
            else
            {
                MessageBox.Show("Please enter both Author and Book Title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
