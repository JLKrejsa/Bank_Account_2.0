using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu
            Console.WriteLine("Welcome to the Bank of Krejsa-Kupresanin");
            Console.WriteLine("How may we serve you today?");

            Account account1 = new Account();
            Account balance1 = new Account();

            List<string> Menu = new List<string>();
            while (true)
            {
                Menu.Add("\n");
                Menu.Add("Enter 1 for Account Summary");
                Menu.Add("Enter 2 for Checking Account Balance");
                Menu.Add("Enter 3 for Savings Account Balance");
                Menu.Add("Enter 4 for Reserve Account Balance ");
                Menu.Add("Enter 5 to Deposit");
                Menu.Add("Enter 6 to Withdraw");
                Menu.Add("Enter 7 to Exit");
                Menu.ForEach(Console.WriteLine);
                int menuChoice = int.Parse(Console.ReadLine());
                Console.Clear();

                if (menuChoice == 1)
                {
                    account1.AccountSummary();
                }

                else if (menuChoice == 2) ;
                {
                    balance1.Balance();
                }
                else if (menuChoice == 3) ;
                {
                    
                }
                else if (menuChoice == 4) ;
                {

                }
                else if (menuChoice == 5) ;
                {
                    Console.WriteLine("Choose Account for Deposit");
                    Console.WriteLine("Enter 1 for Checking");
                    Console.WriteLine("Enter 2 for Savings");
                    Console.WriteLine("Enter 3 for Reserve");
                    int depositAccount = int.Parse(Console.ReadLine());
                    

                    if(depositAccount == 1)
                    {

                    }

                    else if (depositAccount == 2)
                    {

                    }
                    else if(depositAccount == 3)
                    {

                    }

                   

                }
                else if (menuChoice == 6) ;
                {

                }
                else (menuChoice == 7):
                {
                    Console.WriteLine("Thank you. Please visit again.");
                    Console.ReadKey();
                    Console.Clear();
                    Environment.Exit(0);
                }

            //end of while loop
        }
            //else if (menuChoice == 3) ;
            //{

            //}


            //end Main
        }
    }
}
