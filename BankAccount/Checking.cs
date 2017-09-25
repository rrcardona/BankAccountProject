using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking:Account
    {
        public override double Withdrawal(double withdrawalAmount)
        {
            if (currentBalance - withdrawalAmount > 0)
            {
                return currentBalance -= withdrawalAmount;
            }
            else
            {
                return currentBalance;
            }
        }
            public Checking()
        {

        }
        
        }
    }

