namespace Assg_8
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
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();

            BankAccount account1 = new BankAccount(accountNumber, 0);

            Console.WriteLine("Enter deposit amount: ");
            double deposit = double.Parse(Console.ReadLine());

            account1.Deposit(deposit);

            Console.WriteLine($"Account details: ");
            Console.WriteLine($"Account number: {account1.AccountNumber}");
            Console.WriteLine($"Balance: {account1.Balance}");
        }
    }
}
