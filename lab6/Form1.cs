using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public async Task<List<string>> GetBookAsync()
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                                               .Select(b => $"{b.Title} by {b.Author.Name}")
                                               .ToListAsync();

                return books;
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var books = await GetBookAsync();

            if (ListBoxBooks != null)
            {
                ListBoxBooks.DataSource = null;
                ListBoxBooks.DataSource = books;
            }
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);

                await context.SaveChangesAsync();
            }
        }

        public async Task<List<string>> GetBookAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                                               .Select(b => $"{b.Title} by {b.Author.Name}")
                                               .ToListAsync();
                progress?.Report(100);
                return books;
            }
        }
        private async Task LoadBooksAsync()
        {
            progressBar.Visible = true;
            progressBar.Value = 0; 
            var progress = new Progress<int>(value => progressBar.Value = value);

            var books = await GetBookAsync(progress);
            if (ListBoxBooks != null)
            {
                ListBoxBooks.DataSource = null;
                ListBoxBooks.DataSource = books;
            }
            progressBar.Visible = false;
        }
        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text.Trim();
            string bookTitle = txtBookTitle.Text.Trim();

            if (!string.IsNullOrEmpty(authorName) && !string.IsNullOrEmpty(bookTitle))
            {
                await SaveBookAsync(bookTitle, authorName);
                MessageBox.Show("Book and Author saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadBooksAsync();
            }
            else
            {
                MessageBox.Show("Please enter both Author and Book Title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task UpdateBookAsync(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author)
                                              .FirstOrDefaultAsync(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName; 
                    await context.SaveChangesAsync();
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                await UpdateBookAsync(bookId, txtBookTitle.Text.Trim(), txtAuthorName.Text.Trim());
                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadBooksAsync(); 
            }
            else
            {
                MessageBox.Show("Invalid Book ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task DeleteBookAsync(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == bookId);

                if (book == null)
                {
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                context.Books.Remove(book);
                if (!context.Books.Any(b => b.AuthorID == book.AuthorID && b.BookID != book.BookID))
                {
                    context.Authors.Remove(book.Author);
                }

                await context.SaveChangesAsync();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                await DeleteBookAsync(bookId);
                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadBooksAsync(); 
            }
            else
            {
                MessageBox.Show("Invalid Book ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<List<string>> SearchBooksAsync(string searchQuery)
        {
            using (var context = new BookstoreContext())
            {
                return await context.Books
                    .Where(b => b.Title.Contains(searchQuery))
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtAuthorName.Text.Trim();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                var results = await SearchBooksAsync(searchQuery);
                ListBoxBooks.DataSource = null;
                ListBoxBooks.DataSource = results;
            }
            else
            {
                MessageBox.Show("Enter a book title to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

