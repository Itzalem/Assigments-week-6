using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg_4
{
    internal class Circle
    {
        private double _radius;
        public  double Radious { 
            get
            {
                return _radius;
            } 
            set
            {
                if (value > 0)
                _radius = value;
            }
        }
        public double Area
        {
            get
            {
                const double Pi = 3.14;
                return Pi * (_radius * _radius);
            }
        }
        public Circle(double radius)
        {
            Radious = radius;
        }

        public void DisplayInfo() 
        {
            Console.WriteLine($"The radius is {Radious}");
            Console.WriteLine($"The area is {Area}");
        }
    }
}
