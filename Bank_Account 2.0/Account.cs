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
        private string clientName = "Gillian Kate";
        private int accountNumber = 020906;
        private float beginBalance = 0f;

        //properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = "Gillian Kate"; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = 020906; }
        }

        public float BeginBalance
        {
            get { return this.beginBalance; }
            set { this.beginBalance = 0; }
        }
        //constructor
        public Account(string clientName, int accountNumber, float beginBalance)
        {
            this.ClientName = clientName;
            this.AccountNumber = accountNumber;
            this.BeginBalance = beginBalance;
        }

        public Account()
        {
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
            Console.WriteLine("Enter deposit amount");
            float depositAmountEntry = float.Parse(Console.ReadLine());
            this.beginBalance += depositAmountEntry;
            
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter withdraw amount");
            float withdrawAmountEntry = float.Parse(Console.ReadLine());
            this.beginBalance += withdrawAmountEntry;
        }
    }
}
