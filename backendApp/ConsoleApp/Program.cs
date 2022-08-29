using Entities.Models;
using Repositories.Concrete;
using Repositories.Concrete.Context;

var context = new AppDbContext();

Addbook();

void Addbook()
{
    var books = new List<Book>()
{
  new Book()
{
    BookTitle="Suç ve Ceza",
    BookPrice=29,
    BookSummary="özet"
},
  new Book()
{
    BookTitle="Araba Sevdası",
    BookPrice=65,
    BookSummary="özet"
},
  new Book()
{
    BookTitle="Psikopat",
    BookPrice=50,
    BookSummary="özet"
},
  new Book()
{
    BookTitle="Merhamet",
    BookPrice=30,
    BookSummary="özet"
        }
    };


    using (var cont = new AppDbContext())
    {
        context.Books.AddRange(books);
        context.SaveChanges();
    }
    Console.WriteLine($"{books.Count}");
};



