using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            Account balance1 = new Account();
            Account clientName = new Account();
            Account accountNumber = new Account();

            Checking check1 = new Checking();
            Save save1 = new Save();
            Reserve reserve1 = new Reserve();

            //stream writer
 //Name of Client
 //Client Account Number
 //Account Type (Checking, Reserve, or Savings)
 //Each transaction should be on its own line
 //Each transaction should show date and time of transaction(must use DateTime Class)
 //Each transaction should show a “+” for deposit and a “-” for withdrawal
 //Each transaction should show the transaction amount
 //Each transaction should show the new current balance after the transaction


            StreamWriter Check = new StreamWriter("..\\..\\..\\Check.txt");

            using (Check)
            {
                Check.WriteLine(clientName);
                Check.WriteLine("Account Number: " + accountNumber);
                Check.WriteLine("Account Type: " + check1.AccountType);
                Check.WriteLine("Balance: " + check1.CheckBalance);
            }

            StreamWriter Save = new StreamWriter("..\\..\\..\\Save.txt");

            using (Save)
            {
                Save.WriteLine(clientName);
                Save.WriteLine("Account Number: " + accountNumber);
                Save.WriteLine("Account Type: " + save1.AccountTypeS);
                Save.WriteLine("Balance: " + save1.SaveBalance);
            }

            StreamWriter Reserve = new StreamWriter("..\\..\\..\\Reserve.txt");

            using (Reserve)
            {
                Reserve.WriteLine(clientName);
                Reserve.WriteLine("Account Number: " + accountNumber);
                Reserve.WriteLine("Account Type: " + reserve1.AccountTypeR);
                Reserve.WriteLine("Balance: " + reserve1.ReserveBalance);

            }



           //menu
            Console.WriteLine("Welcome to the Bank of Krejsa-Kupresanin");
            Console.WriteLine("How may we serve you today?");

           

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
                    account1.AccountSummary();
                
                else if (menuChoice == 2) 
                 Console.WriteLine("Checking Balance: $" + check1.CheckBalance);
                
                else if (menuChoice == 3) 
                Console.WriteLine("Savings Balance: $" + save1.SaveBalance); 
                
                else if (menuChoice == 4) 
                
                Console.WriteLine("Reserve Balance: $" + reserve1.ReserveBalance);
                            
                else if (menuChoice == 5) 
                {
                    Console.WriteLine("Choose Account for Deposit");
                    Console.WriteLine("Enter 1 for Checking");
                    Console.WriteLine("Enter 2 for Savings");
                    Console.WriteLine("Enter 3 for Reserve");
                    int depositAccount = int.Parse(Console.ReadLine());


                    if (depositAccount == 1)

                        check1.Deposit();


                    else if (depositAccount == 2)

                        save1.SaveDeposit();

                    else if (depositAccount == 3)

                        reserve1.ReserveDeposit();
                }
           
                        else if (menuChoice == 6) 
                {
                    Console.WriteLine("Choose Account for Withdrawal");
                    Console.WriteLine("Enter 1 for Checking");
                    Console.WriteLine("Enter 2 for Savings");
                    Console.WriteLine("Enter 3 for Reserve");
                    int withdrawAccount = int.Parse(Console.ReadLine());


                    if (withdrawAccount == 1)
                    
                        check1.Withdraw();
                    

                    else if (withdrawAccount == 2)
                    
                        save1.SaveWithdraw();
                    
                    else if (withdrawAccount == 3)
                    
                        reserve1.ReserveWithdraw();
                    }                
                    
                        else if (menuChoice == 7) 

                    {
                    Console.WriteLine("Thank you. Please visit again.");
                    Environment.Exit(0);
                    }

               

                } // end of while loop
            //Console.Clear();

        }//end Main   
        }//class program
    }//namespace

