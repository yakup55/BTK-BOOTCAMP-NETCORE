using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle is drawing...");
        }
    }
}
