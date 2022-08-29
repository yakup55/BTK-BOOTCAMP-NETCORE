using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractClass
{
    public class Suv : Car
    {
        public override void StartEnginee()
        {
            Console.WriteLine("Suv Start enginee...");
        }

        public override void StopEnginee()
        {
            Console.WriteLine("Suv Stop enginee...");
        }
    }
}
