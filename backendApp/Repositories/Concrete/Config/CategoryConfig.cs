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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryName).IsRequired();//bos olamaz
            builder.Property(x => x.CategoryDescription).IsRequired();//bos olamaz

            builder.HasData(

                 new Category()
                 {
                     CategoryId = 1,
                     CategoryName = "Computer Science",
                     CategoryDescription = "Computer Science Description"
                 },
                 new Category()
                 {
                     CategoryId = 2,
                     CategoryName = "Network ",
                     CategoryDescription = "Network Description"
                 },
                 new Category()
                 {
                     CategoryId = 3,
                     CategoryName = "Database ",
                     CategoryDescription = "Database Description"
                 }
               );

        }
    }

}
