using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_2._0
{
    class Reserve
    {
        private string accountTypeR = "Reserve";
        private float reserveBalance = 300f;

        //properties
        public string AccountTypeR
        {
            get { return this.accountTypeR; }
            set { this.accountTypeR = "Reserve"; }
        }

       

        public float ReserveBalance
        {
            get { return this.reserveBalance; }
            set { this.reserveBalance = value; }
        }


        //constructor
        public Reserve(string acccountTypeR, float reserveBalance) : base()
        {
            this.accountTypeR = "Reserve";
            this.reserveBalance = 300f;
            
        }

        public Reserve()
        {
        }


        //methods
        public float ReserveDeposit()
        {
            Console.WriteLine("Enter deposit amount");
            float depositAmountEntry = float.Parse(Console.ReadLine());
            this.reserveBalance += depositAmountEntry;
            return reserveBalance;
        }

        public float ReserveWithdraw()
        {
            Console.WriteLine("Enter withdraw amount");
            float withdrawAmountEntry = float.Parse(Console.ReadLine());
            this.reserveBalance += withdrawAmountEntry;
            return reserveBalance;
            
        }

    }
}
