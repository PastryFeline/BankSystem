using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        private double balance;
    


    public double PrintBal()
        {
            return balance;
        }
    public void Deposit(double amount)
        {
            balance +=  amount;
            Console.WriteLine($"{amount} has now been added to balance!!");
        }
    public void Withdraw(double amount)
        {
            balance -= amount;
            Console.WriteLine($"{amount} has now been withrawed from balance!!!");
        }


    }

}
