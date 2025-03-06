using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;


namespace lab7
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


        private const int pageSize = 10;
        private int currentPage = 1;

        public async Task<List<String>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                                         .Include(b => b.Author)
                                         .OrderBy(b => b.BookID)
                                         .Skip((pageNumber - 1) * pageSize)
                                         .Take(pageSize)
                                         .Select(b => $"{b.Title} by {b.Author.Name}")
                                         .ToListAsync();
                return books;
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);
            ListBookBox.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                btnNextPage_Click(sender, e);
            }
        }
        public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);

                    await context.SaveChangesAsync();
                    MessageBox.Show("Book and Author saved Successfully");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
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
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var books = await GetBookAsync();

            if (ListBookBox != null)
            {
                ListBookBox.DataSource = null;
                ListBookBox.DataSource = books;
            }
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookWithHandlingAsync(bookTitle, authorName);
        }
        public async Task ExportBookAsync(string filePath)
        {
            var book = await GetBooksByPageAsync(currentPage);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in book)
                {
                    await writer.WriteLineAsync(item);
                }
            }
        }
        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files(*.txt)|*.txt",
                Title = "Save Book List"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBookAsync(filePath);
                MessageBox.Show("Books exported successfully");
            }
        }
        public async Task<List<Book>> SearchBooksAsync(string title)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var books = await context.Books
                                             .Where(b => b.Title.Contains(title))
                                             .Include(b => b.Author)
                                             .ToListAsync();
                    return books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}");
                return new List<Book>(); 
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string title = txtBookTitle.Text;
            var books = await SearchBooksAsync(title);

            if (books.Any())
            {
                ListBookBox.DataSource = books.Select(b => $"{b.Title} by {b.Author.Name}").ToList();
            }
            else
            {
                MessageBox.Show("No books found.");
            }
        }
    }


}
