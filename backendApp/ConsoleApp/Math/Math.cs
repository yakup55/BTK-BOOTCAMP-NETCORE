using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Math
{
    public class Math
    {
        public int Sum(params int[] numbers)
        {
           int sum = 0;
            foreach (var x in numbers)
            {
                sum += x;
                
            }
            return sum;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Multipy(int a, int b) =>a * b;
        public int Divide(int a, int b) => a / b;
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
