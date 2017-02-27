using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
          //  var myparameter = "10"; // = 10;

            var car = new Car("Volvo");
            //  car.Brand = "Honda"; // not possible if set removed
            Console.WriteLine("Brand: " + car.Brand);
            Console.WriteLine("Speed: " + car.Speed);
            //  car.Speed = 100; // not possible if set removed
            car.Accelerate(20);
            car.Accelerate(10);
            Console.WriteLine("New speed: " + car.Speed);
            car.Break();
            Console.WriteLine("Speed after break: " + car.Speed);

            Console.WriteLine(car.ToString());
            Console.WriteLine(car); // same as .ToString()

            Console.ReadKey();

            // Car secondCar = new Car();


        }
    }
}
