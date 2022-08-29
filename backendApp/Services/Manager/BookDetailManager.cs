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
    public class BookDetailManager : IBookDetailService
    {
        private readonly IBookDetailRepository bookDetailRepository;

        public BookDetailManager(IBookDetailRepository bookDetailRepository)
        {
            this.bookDetailRepository = bookDetailRepository;
        }

        public List<BookDetail> GetAllBookDetails(Expression<Func<BookDetail, bool>> filter = null)
        {
            return bookDetailRepository.GetAll(filter).ToList();
        }

        public BookDetail GetById(int id)
        {
            return bookDetailRepository.Get(x => x.BookDetailId == id);
        }
    }
}
