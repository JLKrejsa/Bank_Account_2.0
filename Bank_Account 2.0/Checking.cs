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
            set { this.accountType = "Checking"; }
        }

        public float CheckBalance
        {
            get { return this.checkBalance; }
            set { this.checkBalance = value; }
        }
        //methods?
    }
}
