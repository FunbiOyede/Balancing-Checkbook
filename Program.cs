using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkbook
{
    class Program
    {
        public  double balance = 0.0;
        //static double DepositAmount,WithdrawAmount;
       static Program program = new Program();
        Transaction transaction = new Transaction();
       

        static void Main(string[] args)
        {
            try
            {
                program.Navigate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                program.Navigate();
            }
          
        }

        public void Navigate()
        {
            Console.WriteLine("Enter 1. Deposit   \n 2. Withdrawal ");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    transaction.Deposit();
                    Navigate();
                    break;
                case 2:
                    transaction.Withdrawal();
                    Navigate();
                    break;
                case 3:
                    Quit();
                    break;
              
                default:
                    throw new FormatException("Value expected");
                    
            }
        }

        public void Quit()
        {

            transaction.ReadBalance();
        }
    }
}
