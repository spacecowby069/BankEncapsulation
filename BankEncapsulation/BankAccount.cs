using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        
        private double balance = 0;

        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            Console.Write("$");
            var deposit = double.Parse(Console.ReadLine());

            balance += deposit;

            Console.WriteLine($"Deposit of ${deposit.ToString("0.00")} confirmed.");
            Console.WriteLine($"Your balance is now ${balance.ToString("0.00")}.");
        }
        
        public void Withdrawal()
        {
            Console.WriteLine("How much would you like to withdrawal?");
            Console.Write("$");
            var withdrawal = double.Parse(Console.ReadLine());
            
            balance -= withdrawal;

            Console.WriteLine($"Withdrawal of ${withdrawal.ToString("0.00")} confirmed.");
            Console.WriteLine($"Your balance is now ${balance.ToString("0.00")}.");
        }

        public void GetBalance()
        {
            Console.WriteLine($"${balance.ToString("0.00")}");
        }
    }
}
