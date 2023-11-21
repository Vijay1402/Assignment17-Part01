using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the account holder name");
            string name = Console.ReadLine();
            BankAccount bacc1 = new BankAccount(name);
            bacc1.displayDetails();
            bacc1.Deposit();
            bacc1.Withdraw();
            Console.ReadKey();

        }
    }
}
