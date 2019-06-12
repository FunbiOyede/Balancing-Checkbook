using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkbook
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu();

            

        }

        public static void mainMenu()
        {
            double balance = 0.0;
            string mainMenuChoice = String.Empty;

            DepositTransaction deposit = new DepositTransaction();
            WithdrawalTransaction withdrawal = new WithdrawalTransaction();

            Console.WriteLine("Enter \n a.Deposit   \nb.Withrawal  \nc. Quit");
            mainMenuChoice = Console.ReadLine().ToLower();

            switch (mainMenuChoice)
            {
                case "a":
                    deposit.Deposit(balance);
                    mainMenu();
                    break;
                case "b":
                    withdrawal.Withdrawal(balance);
                    mainMenu();
                    break;
                //case "c":
                //    quit();
                //    break;

                default:
                    throw new Exception("Invalid Option");
            }
        }
    }
}
