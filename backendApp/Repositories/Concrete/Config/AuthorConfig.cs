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
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.AuthorId);
            builder.Property(x => x.AuthorFirstName).IsRequired();
            builder.Property(x => x.AuthorLastName).IsRequired();
            builder.HasData(

                new Author(){AuthorId=1,AuthorFirstName = "Yakup",AuthorLastName="Yıldırım"},
                new Author(){AuthorId=2,AuthorFirstName = "Murat",AuthorLastName="Çalış"},
                new Author(){AuthorId=3,AuthorFirstName = "Ethem",AuthorLastName="Koç"}
                
                );
         

        }
    }
}
