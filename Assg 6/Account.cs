using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg_6
{

    internal class Account
    {
        private string _accountholder;
        private double _amount;
        public double Amount { 
            get
            {
                return _amount;
            }
            set
            {
                if (value > 0)
                    _amount = value;
                else
                    Console.WriteLine("Enter a positive amount");
            }
        }

        public Account (string accountHolder)
        {
            _accountholder = accountHolder;
            
        }

        public void Deposit(double amount)
        {
            _amount = _amount + amount;
            LogTransaction($"Depositing {amount} was successful");
        }

        private void LogTransaction(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Name: {_accountholder}");
            Console.WriteLine($"Balance: {_amount}");
        }
    }
}
