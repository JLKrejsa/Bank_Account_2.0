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

            //intances of acccounts
            //Account Account = new Account("Jordan", "Belfort", 1000);
            //Checking CheckingAccount = new Checking("Jordan", "Belfort", 1000);
            //Reserve ReserveAccount = new Reserve("Jordan", "Belfort", 1000);
            //Savings SavingsAccount = new Savings("Jordan", "Belfort", 1000);




            Account account1 = new Account();
            Account balance1 = new Account();
            Account clientName = new Account();
            Account accountNumber = new Account();

            Checking check1 = new Checking();
            Savings save1 = new Savings();
            Reserve reserve1 = new Reserve();

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
                    Console.WriteLine("Checking Balance: " + check1.CheckBalance);
                
                else if (menuChoice == 3) ;
                    Console.WriteLine("Savings Balance: " + save1.SaveBalance);
                
                else if (menuChoice == 4) ;
                
                Console.WriteLine("Reserve Balance: " + reserve1.ReserveBalance);
                            
                else if (menuChoice == 5) ;
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
           
                        else if (menuChoice == 6) ;
                {
                    Console.WriteLine("Choose Account for Withdrawal");
                    Console.WriteLine("Enter 1 for Checking");
                    Console.WriteLine("Enter 2 for Savings");
                    Console.WriteLine("Enter 3 for Reserve");
                    int withdrawAccount = int.Parse(Console.ReadLine());


                    if (withdrawAccount == 1)
                    {
                        check1.Withdraw();
                    }

                    else if (withdrawAccount == 2)
                    {
                        save1.SaveWithdraw();
                    }
                    else if (withdrawAccount == 3)
                    {
                        reserve1.ReserveWithdraw();
                    }
                }
                    
                        else if (menuChoice == 7) ;
                    {
                        Console.WriteLine("Thank you. Please visit again.");
                        Console.ReadKey();
                        Console.Clear();
                        Environment.Exit(0);
                    }

                } //end of while loop
            }//end Main   
        }//class program
    }//namespace

