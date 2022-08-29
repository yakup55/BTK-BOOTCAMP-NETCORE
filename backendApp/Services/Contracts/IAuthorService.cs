using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthorList(Expression<Func<Author, bool>> filter = null);
        Author GetById(int id);
        Author AddAuthor(Author author);
        Author UpdateAuthor(Author author,int id);
        void DeleteAuthor(int id);
    }
}
