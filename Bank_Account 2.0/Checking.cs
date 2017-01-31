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

        Checking check1 = new Checking();

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
            this.BeginBalance = 0f;
        }



        //method

       public float CheckDeposit()
        {
            this.checkBalance += depositAmountEntry;
            return base.Deposit(depositAmount);
        }
    }

        //method
        //public override float Deposit(float depositInput)
        //{
        //    this.checkBalance += depositInput;
        //    return base.Deposit(depositInput);
        //}

        ////SAME FORMAT FOR WITHDRAW BUT USE -= in method

        //public override void PrintAccountBalance()
        //{
        //    //info that you want to show when user want to print the account balance such as CW(CheckBalance);
       
        //once you have this down for checking you can copy and paste it into savings 
        //and reserve and just change the variables respectively
        

    }
}
