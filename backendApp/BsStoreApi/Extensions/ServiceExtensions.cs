using Microsoft.EntityFrameworkCore;
using Repositories.Concrete.Context;
using Repositories.Concrete.EntityFramework;
using Repositories.Contracts;
using Services.Contracts;
using Services.Manager;

namespace BsStoreApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlConnection(this IServiceCollection services,IConfiguration configuration){
            services.AddDbContext<AppDbContext>(
                x => x.UseSqlServer(configuration.GetConnectionString("sqlConnection")
                ));
        }
        public static void RegisterToIo(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookManager>();
            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IBookRepository, EfBookRepository>();
            services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            services.AddScoped<IAuthorRepository, EfAuthorRepository>();

            services.AddScoped<IBookDetailService, BookDetailManager>();
            services.AddScoped<IBookDetailRepository, EfBookDetailRepository>();

            services.AddScoped<IBookAuthorService,BookAuthorManager>();
            services.AddScoped<IBookAuthorRepository, EfBookAuthorRepository>();
        }
    }
    
}
