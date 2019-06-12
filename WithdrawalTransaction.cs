using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkbook
{
    class WithdrawalTransaction
    {

       public  void Withdrawal(double value)
        {

          
            double finalValue;
            Console.WriteLine("Enter Value");
            string withdrawalValue = Console.ReadLine();
            bool withdrawBool =  double.TryParse(withdrawalValue, out finalValue);
            if (!withdrawBool) throw new Exception("Conversion failed");
            else
                value = value - finalValue;
            Console.WriteLine("balance is {0}",value);

        }
    }

}
