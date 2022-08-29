using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Book
    {
        public Book(int bookId, string bookTitle, string bookSummary, int bookPrice)
        {
            BookId = bookId;
            BookTitle = bookTitle;
            BookSummary = bookSummary;
            BookPrice = bookPrice;
        }

        public Book()
        {
        }

        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookSummary { get; set; }
        public int BookPrice { get; set; }

        public override string ToString()
        {
            return $"{this.BookId},{this.BookTitle},{this.BookPrice},{this.BookSummary}";
        }
    }
}
