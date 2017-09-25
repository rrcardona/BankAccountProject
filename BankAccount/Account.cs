using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        protected int accountNumber;
        protected string accountType;
        protected double currentBalance;
        protected double moneyAvailable;


        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
        public double CurrentBalance
        {
            get { return this.currentBalance; }
            set { this.currentBalance = value; }
        }
        public double MoneyAvailable
        {
            get { return this.moneyAvailable; }
            set { moneyAvailable = value; }
        }
        public Account()
        {

        }
        abstract public double Withdrawal(double withdrawalAmount);

        public double Deposit(double depositAmount)
        {
            currentBalance += depositAmount;
            return currentBalance;
        }
    }
}
