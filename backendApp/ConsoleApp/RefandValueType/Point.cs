using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.RefandValueType
{
    public class Point
    {
        public int x { get; set; }

        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
        }

        public override string ToString()
        {
            return $"x={x} y={y}";
        }
    }
}
