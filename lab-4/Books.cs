using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.");

            Title = title;
            Author = author;
        }

        public virtual string GetInfo()
        {
            return $"{Title} by {Author}";
        }
    }

    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, string author, int issueNumber)
            : base(title, author)
        {
            if (issueNumber < 1)
                throw new ArgumentException("Issue number must be positive.");

            IssueNumber = issueNumber;
        }

        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber}";
        }
    }
    public class Textbook : Book
    {
        public string Subject { get; set; }

        public Textbook(string title, string author, string subject)
            : base(title, author)
        {
            if (string.IsNullOrWhiteSpace(subject))
                throw new ArgumentException("Subject cannot be empty.");

            Subject = subject;
        }

        public override string GetInfo()
        {
            return $"{Title} (Textbook on {Subject}) by {Author}";
        }
    }

}
