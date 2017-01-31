using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_2._0
{
    class Save : Account
    {
        private string accountTypeS = "Saving";
        private float saveBalance = 200f;

        //properties
        public string AccountTypeS
        {
            get { return this.accountTypeS; }
            set { this.accountTypeS = "Saving"; }
        }

        public float SaveBalance
        {
            get { return this.saveBalance; }
            set { this.saveBalance = 200f; }
        }



        ////constructor
        public Save(string acccountType, float saveBalance) : base()
        {
            this.accountTypeS = "Saving";
            this.saveBalance = 200f;
        }

        public Save()
        {
        }


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

