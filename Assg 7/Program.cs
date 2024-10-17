namespace Assg_7
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
            Console.WriteLine("Enter product name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter product price: ");
            int price = int.Parse(Console.ReadLine());


            Product product = new Product(name, price);

            Console.WriteLine("");
            Console.WriteLine("Product details:");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price: {product.Price}");
        }
    }
}
