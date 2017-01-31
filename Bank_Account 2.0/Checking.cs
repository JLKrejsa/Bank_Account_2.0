using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_2._0
{
    class Checking:Account
    {
        private string accountType = "Checking";
        private float checkBalance;



        //properties

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public float CheckBalance
        {
            get { return this.checkBalance; }
            set { this.checkBalance = value; }
        }

       

        //constructor
        public Checking (string acccountType, float checkBalance) : base ()
        {
            this.accountType = "Checking";
            this.checkBalance = 200f;
            
        }

        public Checking()
        {
        }



        //method

        public float Deposit()
        {
            Console.WriteLine("Enter deposit amount");
            float depositAmountEntry = float.Parse(Console.ReadLine());
            this.checkBalance += depositAmountEntry;
            return checkBalance;
        }

        public float Withdraw()
        {
            Console.WriteLine("Enter withdraw amount");
            float withdrawAmountEntry = float.Parse(Console.ReadLine());
            this.checkBalance += withdrawAmountEntry;
            return checkBalance;
        }

        


    }
}
