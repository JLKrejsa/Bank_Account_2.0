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
        private string accountNumber = "020906";
        

        //properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = "Gillian Kate"; }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = "020906"; }
        }

    //constructor
    public Account(string clientName, string accountNumber)
    {
        this.ClientName = clientName;
        this.AccountNumber = accountNumber;

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



    //end of Account class  
}
    }

