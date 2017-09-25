using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu display = new Menu();
            display.Greeting();

            Client clientInfo = new Client();
            clientInfo.AccountName = Console.ReadLine();
            clientInfo.AccountAddress = "141 Piletas Arce \nLares, Puerto Rico \n00669";
            clientInfo.AccountPhone = "(787)762-1410";

            Checking checkingAccount = new Checking();
            checkingAccount.AccountNumber = 900785211;
            checkingAccount.AccountType = "Checking";
            checkingAccount.CurrentBalance = 987.33;

            Savings savingsAccount = new Savings();
            savingsAccount.AccountNumber = 900785212;
            savingsAccount.AccountType = "Savings";
            savingsAccount.CurrentBalance = 101.69;

            int userChoice = 0;
            double amount;

            Console.WriteLine(  );
            display.DisplayHeader();
            Console.WriteLine();

            do
            {
                display.MenuOptions();
                Console.Write(" Please select a number of your choice ");
                userChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (userChoice)
                {
                    case 1:
                        Console.Write("How much money would you like to deposit to your Checking Account: $");
                        amount = Convert.ToDouble(Console.ReadLine());
                        checkingAccount.Deposit(amount);
                        Console.WriteLine(" Your current checking account balance is now ${0}", " " + checkingAccount.CurrentBalance);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("How much money would you like to deposit to your Savings Account: $");
                        amount = Convert.ToDouble(Console.ReadLine());
                        savingsAccount.Deposit(amount);
                        Console.WriteLine(" Your current savings account balance is now ${0}", " " + savingsAccount.CurrentBalance);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("How much would you like to withdraw from your Checking Account: $");
                        amount = Convert.ToDouble(Console.ReadLine());
                        checkingAccount.Withdrawal(amount);
                        Console.WriteLine(" Your current checking account balance is now ${0}", " " + checkingAccount.CurrentBalance);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("How much money would you like to withdraw from your Savings Account: $");
                        amount = Convert.ToDouble(Console.ReadLine());
                        savingsAccount.Withdrawal(amount);
                        Console.WriteLine(" Your current savings account balance is now ${0}", " " + savingsAccount.CurrentBalance);
                        Console.WriteLine();
                        break;
                    case 5:
                        clientInfo.DisplayAccount(clientInfo.AccountName);
                        Console.WriteLine();
                        break;
                    case 6:
                        
                        Console.WriteLine("{0}    {1}\t\t\t{2}\t\t\n", checkingAccount.AccountType, checkingAccount.AccountNumber, checkingAccount.CurrentBalance);
                        Console.WriteLine("{0}    {1}\t\t\t{2}\t\t\n", savingsAccount.AccountType, savingsAccount.AccountNumber, savingsAccount.CurrentBalance);
                        Console.WriteLine();
                        break;
                }
            } while (userChoice != 7);
            Console.WriteLine("Thank you for being a valued customer at TreeBank. Have a good day");




        }
    }
}
