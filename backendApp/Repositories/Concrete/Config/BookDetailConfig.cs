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
    public class BookDetailConfig : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(x => x.BookDetailId);
            builder.Property(x => x.BookNumberOfPage).IsRequired();
            builder.Property(x => x.BookCity).IsRequired();
            builder.Property(x => x.BookISBN).IsRequired();
            builder.Property(x => x.BookLanguage).IsRequired();
            builder.Property(x => x.BookPublisher).IsRequired();


            builder.HasData(new BookDetail()
            {
                BookDetailId = 1,
                BookId = 1,
                BookCity = "Samsun",
                BookISBN = "1234-5456-1234",
                BookCountry = "Turkey",
                BookLanguage = "Turkish",
                BookNumberOfPage = 100,
                BookPublisher = "Samsun University"
            });
            #region samples
            #endregion
        }
    }
}
