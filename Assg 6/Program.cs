using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace Assg_6
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
            Console.WriteLine("Enter the name of the holder");
            string accountHolder = Console.ReadLine();  

            Account account1 = new Account(accountHolder);

            Console.WriteLine("Enter deposit amount");
            int amount = int.Parse(Console.ReadLine());

            account1.Deposit(amount);
            account1.DisplayAccountInfo();
        }

    }
}
