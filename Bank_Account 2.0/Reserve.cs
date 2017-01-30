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
        private float reserveBalance;

        //properties
        public string AccountTypeR
        {
            get { return this.accountTypeR; }
            set { this.accountTypeR = "Reserve"; }
        }
    }
}
