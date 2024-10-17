using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg_3
{
    internal class Car
    {
        private string _make;
        public string Make { get; set; }
        private string _model;
        public string Model { get; set; }
        private int _year;
        public int Year { get; set ; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}
