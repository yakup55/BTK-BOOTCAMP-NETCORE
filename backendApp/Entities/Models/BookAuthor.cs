using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class BookAuthor
    {
        public int BookAuthorId { get; set; }

        //Book
        public int? BookId { get; set; }
        public Book? Book { get; set; }

        //Author
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
