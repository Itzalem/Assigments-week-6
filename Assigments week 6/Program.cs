using System;

namespace Assigments_week_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Person person1 = new Person(name,age);

            Console.WriteLine("");
            Console.WriteLine($"Your name is {person1.Name}");
            Console.WriteLine($"Your age is {person1.Age}");
        }
    }
}
