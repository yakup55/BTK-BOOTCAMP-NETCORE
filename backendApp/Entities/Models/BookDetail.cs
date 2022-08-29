using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        public int BookNumberOfPage { get; set; }
        public string BookISBN { get; set; }
        public string BookCountry { get; set; }
        public string BookCity { get; set; }
        public string BookLanguage { get; set; }
        public string BookPublisher{ get; set; }


        public int? BookId { get; set; }
        //Navigation property
        public Book? Books { get; set; }

    }
}
