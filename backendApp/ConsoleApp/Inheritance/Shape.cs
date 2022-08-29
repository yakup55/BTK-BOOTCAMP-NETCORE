using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    public class Shape
    {
        public int x { get; set; }
        public int y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Shape drawing...");
        }
    }
}
