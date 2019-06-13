using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkbook
{
    class DepositTransaction
    {

        double DepositAmount;
        public void Deposit(double value)
        {
            //double depositValue;
            
            Console.WriteLine("Enter Amount");
            DepositAmount = Double.Parse(Console.ReadLine());
            //bool depositBool =  Double.TryParse(DepositAmount, out depositValue);
            // if (!depositBool) throw new Exception("Conversion failed");
            // else
            //     value = depositValue + value;
            DepositAmount += value;

            
             Console.WriteLine("balance is {0}",value);
        }


    }
}
