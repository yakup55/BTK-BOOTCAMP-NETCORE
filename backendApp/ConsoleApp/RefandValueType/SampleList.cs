using ConsoleApp.AbstractClass;
using ConsoleApp.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.RefandValueType
{
    public class SampleList
    {
        //static veriyi new lemeye gerek yok
        //classlar referanca tip
        public static void Run()
        {
            var list1 = new List<String>
{
    "Ahmet","Yakup","Alperen"
};
            var list2 = list1;
            list2.Add("Burak");

            list1.ForEach(x => Console.WriteLine(x));
        }
        public static void RunPoint()
        {
            var p1 = new Point(3, 4);
            Console.WriteLine(p1);
            var p2 = p1;

            p2.x = 20;
            p2.y = 50;
            Console.WriteLine(p1);
        }
        public static void RunInheritance()
        {
            var list = new List<Shape>()
{
    new Shape() { x = 3, y = 10 },
    new Rectangle() { x = 8, y = 20 },
    new Circle(){    x = 30,    y = 50},
    new Triangle() { x = -1, y = -11 },
    new Square() { x = 4, y = 4 }
};
            list.ForEach(x => x.Draw());
        }
        public static void RunInterface()
        {
            var carList = new List<Car>()
{
    new Cabrio(){CarId=1,CarBrand="BMV",CarModel="525",CarYear=2018},
    new Suv(){CarId=2,CarBrand="Mercedes",CarModel="GLC",CarYear=2017},
    new Suv(){CarId=2,CarBrand="Cercedes",CarModel="GLC",CarYear=2017},
    new Suv(){CarId=3,CarBrand="Audi",CarModel="Q7",CarYear=2019},
    new Cabrio(){CarId=4,CarBrand="Porsche",CarModel="911 Carrea",CarYear=2022},
};

            carList.Sort();
            carList.ForEach(c => Console.WriteLine(c));
        }
    }
}
