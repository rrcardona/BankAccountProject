using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Menu
    {
        public void Greeting()
        {
            Console.WriteLine("Welcome to TreeBank - Where Money does grow on trees. \n\nPlease enter your first and last name so we can access your account");
        }
        public void MenuOptions()
        {
            Console.WriteLine("1 - Deposit to Checking \n2 - Deposit to Savings \n3 - Withdraw from Checking \n4 - Withdraw from Savings \n5 - View Account Information \n6 - View Balance \n7 - Exit \n" );
        }

        public void DisplayHeader()
        {
            Console.WriteLine("Please select a choice from the menu options below");
        }
    }
}
