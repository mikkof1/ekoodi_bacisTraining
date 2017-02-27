using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    public class Car
    {
        private double _speed;

        public Car(string brand)
        {
            Brand = brand;
            _speed = 0;
        }

        public Car()
        {
            _speed = 0;
        }

        public string Brand { get; } // set; }
        //     set { _brand = value; } // remove if not needed
       // }


        public double Speed
        {
            get { return _speed; }
         //   set { _speed = value; } // remove if not needed
        }

        public void Accelerate(double accleration)
        {
            _speed = _speed + accleration;
        }

        public void Break()
        {
            _speed = _speed - 10;
        }

        public override string ToString()
        {
         //   return base.ToString();
            return Print();

        }

        private string Print()
        {
            return "Brand: "+ Brand + " , Speed: "+_speed;
        }
    }
}
