using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg_7
{
    internal class Product
    {
        public string Name;
        public double Price { get;  private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
