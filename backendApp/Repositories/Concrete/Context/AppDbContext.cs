using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Concrete.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book>? Books { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Author>? Authors { get; set; }
        public DbSet<BookDetail>? BookDetails { get; set; }
        public DbSet<BookAuthor>? BookAuthors { get; set; }

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=BsStore;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new BookConfig());
            //modelBuilder.ApplyConfiguration(new CategoryConfig());
            //modelBuilder.ApplyConfiguration(new AuthorConfig());

            //hepsini bir anda config ediyor..
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
