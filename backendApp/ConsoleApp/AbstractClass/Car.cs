using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractClass
{
    public abstract class Car:IComparable
    {
        public int CarId { get; set; }
        public string? CarBrand { get; set; }
        public string? CarModel { get; set; }
        public int CarYear { get; set; }

        public abstract void StartEnginee();
        public abstract void StopEnginee();

        public virtual void OpenLight()
        {
            Console.WriteLine("Light is open .");
        }

        public override string ToString()
        {
            return $"{CarBrand,-15} {CarModel,-15} {CarYear,-8}";
        }

        public int CompareTo(object? obj)
        {
            //0 eşit
            //1 büyüktür
            //-1 kücüktür
            var other =obj as Car;//CAST Car gibi davranıyor

            if(obj == null)
            {
                throw new Exception("obj is not car");
            }
            //if (this.CarYear > other.CarYear)
            //{
            //    return 1;
            //}
            //else if(this.CarYear < other.CarYear)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}
            //VEYA
            return this.CarBrand.CompareTo(other?.CarBrand);
        }

    }
    
}
