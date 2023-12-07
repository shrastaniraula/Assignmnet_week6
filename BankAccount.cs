using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet_week6
{
    internal class BankAccount
    {
        private String accountNumber;
        private decimal balance;

        public BankAccount(String accountNumber, decimal balance = 0)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void Display()
        {
            Console.WriteLine(balance);
        }


    }
}
