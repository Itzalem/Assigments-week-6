using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg_8
{
    internal class BankAccount
    {
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            amount = Balance + amount;
            Withdraw(amount);            
        }

        private void Withdraw(double amount)
        {
            Console.WriteLine("Enter withdrawal amount: ");
            double withdraw = double.Parse(Console.ReadLine());

            Balance = amount - withdraw;
        }
    }
}
