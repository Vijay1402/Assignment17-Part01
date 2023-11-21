using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_01
{
    public class BankAccount
    {
        readonly int accountNumber;
        string accountHolderName;
        private double Balance;

        public BankAccount(string AccountHolderName)
        {
            Random random = new Random();
            accountNumber = random.Next(100000,999999);
            this.accountHolderName = AccountHolderName;
            Balance = 0;
        }
        public double balance { get { return Balance; } set { Balance = value; } }

        public void displayDetails()
        {
            Console.WriteLine("Account Number:\t" + accountNumber);
            Console.WriteLine("Account Holder Name:\t" + accountHolderName);
            Console.WriteLine("Account Balance:\t" + balance);
        }

        public void Deposit()
        {
            double depositAmt;
            Console.WriteLine("Enter the amount to be deposited");
            depositAmt = double.Parse(Console.ReadLine());
            this.balance += depositAmt;
            displayDetails();
        }
        public void Withdraw()
        {
            double withdrawAmt;
            Console.WriteLine("Enter the amount to be withdrawn");
            withdrawAmt = double.Parse(Console.ReadLine());
            this.balance -= withdrawAmt;
            displayDetails();
        }

    }
}
