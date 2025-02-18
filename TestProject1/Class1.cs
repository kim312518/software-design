using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WinFormsApp1.Tests
{
    [TestClass]
    public class PolymorphismTests
    {
        [TestMethod]
        public void TestPolymorphismBehavior()
        {
            Book[] books = new Book[]
            {
                new Book { Title = "Generic Book", Author = "John Smith" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
                new Ebook { Title = "Learn C#", Author = "Alice Brown", FileSizeMB = 5 }
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo(), "Book GetInfo() failed");
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo(), "Magazine GetInfo() failed");
            Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo(), "Ebook GetInfo() failed");
        }
    }
}
