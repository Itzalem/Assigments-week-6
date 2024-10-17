using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigments_week_6
{
    class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { 
                if (_age >= 0) 
                _age = value; 
            }
        }

        public Person(string name, int age)
        {
           Name = name;
           Age = age;
        }
    }
}
