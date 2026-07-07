using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    internal class BankAccount
    {
        public string AccountNumber { get; }
        private string owner;
        public double Balance { get; private set; }
        public BankAccount (string accountNumber){
            this.AccountNumber = accountNumber;
        }
        public string Owner
        {
            get { return owner; }
            set
            {
                if (value != "")
                {
                    owner = value;
                }
                else
                {
                    Console.WriteLine("Owner is not empty");
                }
            }
        }
        public double Deposit(double amount)
        {
            if(amount > 0)
            {
                return Balance += amount;
            }

            return 0;
        }
        public double Withdraw(double amount)
        {
            if(Balance > amount && amount > 0)
            {
               return Balance -= amount;
            }
            else
            {
                Console.WriteLine("So du khong du de thuc hien rut tien");
            }
            return Balance;
        }



    }
}
