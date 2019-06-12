using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkbook
{
    class DepositTransaction
    {
        public void Deposit(double value)
        {
            double depositValue;
            Console.WriteLine("Enter Amount");
            string DepositAmount = Console.ReadLine();
           bool depositBool =  Double.TryParse(DepositAmount, out depositValue);
            if (!depositBool) throw new Exception("Conversion failed");
            else
                value = value + depositValue;
             Console.WriteLine("balance is {0}", value);
        }
    }
}
