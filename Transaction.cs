using System;
using System.IO;

namespace checkbook
{
    class Transaction
    {
        public double balance;
      private  double WithdrawAmount = 0, DepositAmount = 0;

        public void Deposit()
        {
            Console.WriteLine("Enter Amount");
            string DepositValue = Console.ReadLine();

            bool boolValue = Double.TryParse(DepositValue, out DepositAmount);
            if (!boolValue)
                 throw new Exception("Invalid value, double expected");
            else
            balance += DepositAmount;
            Console.WriteLine("balance is {0}", balance);
            WriteToFile();
        }


        public void Withdrawal()
        {
            
            Console.WriteLine("Enter Amount");
            string WithdrawValue = Console.ReadLine();

            bool boolValue = Double.TryParse(WithdrawValue, out WithdrawAmount);
            if (!boolValue)
                 throw new Exception("Invalid value, double expected");
            else
            balance -= WithdrawAmount;
            Console.WriteLine("balance is {0}", balance);

            WriteToFile();
        }


      

        public void WriteToFile()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            using (StreamWriter sr = new StreamWriter(Path.Combine(filePath, "checkbook.txt")))
            {
                sr.Write(balance);
            }
        }

        public void ReadBalance()
        {
            try
            {
                using (StreamReader sr = new StreamReader("checkbook.txt"))
                {
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
    }
}
