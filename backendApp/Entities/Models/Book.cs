using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
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
        public decimal BookPrice { get; set; }
        public DateTime BookAtCreated { get; set; }

        public BookDetail BookDetails { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

        // navigation
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public override string? ToString()
        {
            return $"{BookTitle} {BookSummary} {BookPrice}";
        }

     
    }
}
