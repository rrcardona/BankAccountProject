using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings:Account
    {
        protected double minimumBalance;

        public double MinimumBalance
        {
            get { return this.minimumBalance; }
            set { minimumBalance = value; }
        }

        public Savings()
        {

        }

        public override double Withdrawal(double withdrawalAmount)
        {
            this.minimumBalance = 100;
            if (currentBalance - withdrawalAmount < minimumBalance)
            {
                Console.WriteLine();
                Console.WriteLine(" I'm sorry but you're Savings Account requires to maintain a minimum balance of $100." );
                return 0;
            }
            else
            {
                currentBalance -= withdrawalAmount;
                return currentBalance;
            }
            
        }
    }
}
