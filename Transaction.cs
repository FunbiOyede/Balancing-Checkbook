using System;

namespace checkbook
{
    class Transaction
    {
        public double balance;
      
        public void Deposit()
        {
            double DepositAmount;
            Console.WriteLine("Enter Amount");
            string DepositValue = Console.ReadLine();
              bool deposit =  Double.TryParse(DepositValue, out DepositAmount);
            if (!deposit)
            {
                throw new Exception("Invalid value, double expected");
            }
           balance += DepositAmount;
            Console.WriteLine("balance is {0}", balance);
       
        }


        public void Withdrawal()
        {
            double WithdrawAmount;
            Console.WriteLine("Enter Amount");
       
            string WithdrawValue = Console.ReadLine();
          bool withdraw =   Double.TryParse(WithdrawValue, out WithdrawAmount);
            if(!withdraw)
            {
                throw new Exception("Invalid value, double expected");
            }
            balance -= WithdrawAmount;
            Console.WriteLine("balance is {0}", balance);

        }


        public void handleException()
        {

        }

    }
}
