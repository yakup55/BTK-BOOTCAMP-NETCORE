using Entities.Models;
using Repositories.Concrete.Context;
using Repositories.Contracts;

namespace Repositories.Concrete.EntityFramework
{
    public class EfBookDetailRepository : EfBaseRepository<BookDetail>, IBookDetailRepository
    {
        public EfBookDetailRepository(AppDbContext context) : base(context)
        {
        }
    }
}
