using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Math;
using ConsoleApp;
namespace ConsoleApp
{
    public class Pratice
    {

      public  void ArrayDefination()
        {
            var books = new Book[]{new Book(1,"Devlet","Devletii",20),
    new Book(2, "Marslı", "Marslıı", 30) };
            var newArrayBook = new Book[5];

            for (int i = 0; i < books.Length; i++)
            {
                newArrayBook[i] = books[i];
                Console.WriteLine(newArrayBook[i]);
            }
            newArrayBook[2] = new Book(3, "Test", "ee", 30);

        }
       public void UseMathInProgram()
        {
            
            var math = new ConsoleApp.Math.Math();
            var divide = math.Divide(10, 5);
            Console.WriteLine(divide);

            var multiple = math.Multipy(3, 6);
            Console.WriteLine(multiple);
        }
      public  void UseParamsKeyWord()
        {
            var math = new ConsoleApp.Math.Math();
            Console.WriteLine(math.Sum(1, 3));
            Console.WriteLine(math.Sum(10));
            Console.WriteLine(math.Sum(1, 3, 4, 5));
            Console.WriteLine(math.Sum(1, 3, 4, 5, 10, 20));

        }


    }
}
