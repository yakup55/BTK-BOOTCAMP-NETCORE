using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Manager
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorManager(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public Author AddAuthor(Author author)
        {
            if (author is null)
            {
                throw new Exception();
            }
            authorRepository.Add(author);
            return author;
        }

        public void DeleteAuthor(int id)
        {
            var delete = GetById(id);
            authorRepository.Delete(delete);
            
        }

        public List<Author> GetAllAuthorList(Expression<Func<Author, bool>> filter = null)
        {
            return authorRepository.GetAll(filter);
        }

        public Author GetById(int id)
        {
            var author= authorRepository.Get(x=>x.AuthorId==id);
            if (author == null)
            {
                throw new Exception("Author could not found");
            }
            return author;
        }

        public Author UpdateAuthor(Author author, int id)
        {
            var authorentity=GetById(id);
            if (author.AuthorId != id)
            {
                throw new Exception();
            }
            authorentity.AuthorFirstName = author.AuthorFirstName;
            authorentity.AuthorLastName = author.AuthorLastName;
            authorRepository.Update(authorentity);
            return authorentity;
        }
    }
}
