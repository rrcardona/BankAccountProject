using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        protected string accountName;
        protected string accountAddress;
        protected string accountPhone;         
        
        public string AccountName
        {
            get { return this.accountName; }
            set { accountName = value; }
        }
        public string AccountAddress
        {
            get { return this.accountAddress; }
            set { accountAddress = value; }
        }
        public string AccountPhone
        {
            get { return this.accountPhone; }
            set { accountPhone = value; }
        }
        public void DisplayAccount(string accountName)
        {
            this.accountName = accountName;
            Console.WriteLine("\n\t{0}\n\tAccount Information : {1}\n\t{2}\n\n\n",accountName,accountAddress,accountPhone);
        }
        public Client()
        {

        }
    }
}
