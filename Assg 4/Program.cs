namespace Assg_4
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
            Console.Write("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());

            Circle circle1 = new Circle(radius);

            circle1.DisplayInfo();
        }
    }
}
