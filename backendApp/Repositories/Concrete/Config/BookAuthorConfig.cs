using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete.Config
{
    public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(x => x.BookAuthorId);

            //Book-BookAuthor
            builder.HasOne(x => x.Book).WithMany(y => y.BookAuthors).HasForeignKey(x => x.BookId).OnDelete(DeleteBehavior.Cascade);

            //Author-BookAuthor
            //builder.HasOne(x => x.Author).WithMany(y => y.BookAuthors).HasForeignKey(x => x.AuthorId).OnDelete(DeleteBehavior.Cascade);


            builder.HasData(
                new BookAuthor() { BookAuthorId = 1, BookId = 1, AuthorId = 1 },
                new BookAuthor() { BookAuthorId = 3, BookId = 1, AuthorId = 2 },
                new BookAuthor() { BookAuthorId = 4, BookId = 1, AuthorId = 3 },
                new BookAuthor() { BookAuthorId = 2, BookId = 2, AuthorId = 3 }
                );
        }
    }
}
