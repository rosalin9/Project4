using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public int accNumber;
        public string name;
        private double _accBalance;

        public double AccBalance 
        {
            get
            {
                return _accBalance;
            }
            set
            {
                _accBalance = value;
            }
        }

        public Account(int accNum, string custName) 
        {
            accNumber = accNum;
            name = custName;
        }

        public void CustDetail()
        {
            Console.WriteLine("Hello! {0} Welcome to Bank Withdrawl & Deposit Machine!", name);
        }
        public void Deposit()
        {
            Console.WriteLine("Enter the amount to be deposited: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            _accBalance += amount;

            Console.WriteLine("The Balance in account is: {0}", _accBalance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount to be withdraw: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > _accBalance)
                Console.WriteLine("Insufficient Balance");
            else
                _accBalance -= amount;

            Console.WriteLine("The Balance in account is: {0}", _accBalance);
        }
    }
}
