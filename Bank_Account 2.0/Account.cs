using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_2._0
{
    class Account
    {
        //fields
        private string clientName = "Gillain Kate";
        private int accountNumber = 020906;
        private float beginBalance = 0;

        //properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = "Gillian Kate"; }
        }

        protected int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = 020906; }
        }

        protected float BeginBalance
        {
            get { return this.beginBalance; }
            set { this.beginBalance = 0; }
        }

        //methods
        public void AccountSummary()
        {
            Console.WriteLine("Name " + clientName);
            Console.WriteLine("Account number " + accountNumber);
        }

        public void Balance()
        {
            Console.WriteLine("Balance " + this.beginBalance);
        }


        public void Deposit()
        {

        }
    }
}
