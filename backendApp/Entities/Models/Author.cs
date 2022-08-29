using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Author
    {
        public Author(int authorId, string authorFirstName, string authorLastName)
        {
            AuthorId = authorId;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
        }
        public Author()
        {

        }

        public int AuthorId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }

        //public ICollection<BookAuthor> BookAuthors { get; set; }

        public override string ToString()
        {
            return $"{AuthorFirstName} {AuthorLastName}";
        }
    }
}
