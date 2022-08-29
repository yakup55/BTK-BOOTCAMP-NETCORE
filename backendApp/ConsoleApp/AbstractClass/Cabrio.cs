using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractClass
{
    public class Cabrio : Car
    {
        public override void StartEnginee()
        {
            Console.WriteLine("Cabrio start enginee...");
        }

        public override void StopEnginee()
        {
            Console.WriteLine("Cabrio stop enginee...");
        }

    }
}
