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
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.BookId);//primary key olduğunu belirttik 
            builder.Property(x => x.BookTitle).IsRequired();//bos olamaz
            builder.Property(x => x.BookSummary).IsRequired();//bos olamaz
            builder.Property(x => x.BookPrice).HasDefaultValue(10);//girilmesse 10 verir
            builder.Property(b => b.BookAtCreated).HasDefaultValueSql("GETDATE()");

            builder.HasData(
                new Book() { BookId = 1, BookTitle = "Devlet", BookPrice = 20, BookSummary = "Nutuk" },
                  new Book() { BookId = 2, BookTitle = "Vatan", BookPrice = 270, BookSummary = "Vatan " },
                  new Book() { BookId = 3, BookTitle = "Silah", BookPrice = 70, BookSummary = "Silah " }
                );
            builder.HasOne(b => b.Category)
               .WithMany(c => c.Books)
               .HasForeignKey(b => b.CategoryId)
               .OnDelete(DeleteBehavior.SetNull);


        }
    }
}
