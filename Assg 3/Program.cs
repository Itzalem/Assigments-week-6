namespace Assg_3
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
            Console.Write($"Enter car make: ");
            string make = Console.ReadLine();

            Console.Write($"Enter car model: ");
            string model = Console.ReadLine();

            Console.Write($"Enter car year: ");
            int year = int.Parse(Console.ReadLine());

            Car car1 = new Car(make,model,year);

            Console.WriteLine("");
            Console.WriteLine("Car details");
            Console.WriteLine($"Make: {car1.Make}");
            Console.WriteLine($"Model: {car1.Model}");
            Console.WriteLine($"Year: {car1.Year}");

        }
    }
}
