using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_2._0
{
    class Savings:Account
    {
        private string accountTypeS = "Saving";
        private float saveBalance;

        //properties
        public string AccountTypeS
        {
            get { return this.accountTypeS; }
            set { this.accountTypeS = "Saving"; }
        }

        public float SaveBalance
        {
            get { return this.saveBalance; }
            set { this.saveBalance = 200; }
        }



        ////constructor
        public Savings(string acccountType, float saveBalance) : base()
        {
            this.accountTypeS = "Saving";
            this.saveBalance = 200f;
        }

        public Savings()
        {
        }

        //constructor
        //public Savings(string acccountTypeS, float saveBalance) : base ()
        //{
        //    this.accountTypeS = "Savings";
        //    this.saveBalance = 200f;

    

        //public Savings()
        //{

        //}



        //methods
        public float SaveDeposit()
        {
            Console.WriteLine("Enter deposit amount");
            float depositAmountEntry = float.Parse(Console.ReadLine());
            this.saveBalance += depositAmountEntry;
            return saveBalance;
        }

    public float SaveWithdraw()
    {
        Console.WriteLine("Enter withdraw amount");
        float withdrawAmountEntry = float.Parse(Console.ReadLine());
        this.saveBalance += withdrawAmountEntry;
        return saveBalance;

    }




   }
}

