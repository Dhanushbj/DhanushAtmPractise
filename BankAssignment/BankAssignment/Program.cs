using System;

namespace BankAssignment
{
    class Account
    {
        long AccNo;
        double bal;
        string[] payees;
        long[] payeesAccount;
        public Account(long AccNo, double bal)
        {
            this.AccNo = AccNo;
            this.bal = bal;
        }
        public Account(long accountNo, double bal, string[] payees, long[] payeesAccount)
        {
            this.AccNo = AccNo;
            this.bal = bal;
            this.payees = payees;
            this.payeesAccount = payeesAccount;

        }
        public bool DebitAmount(double amount)
        {
            if (amount <= this.bal)
            {
                this.bal = this.bal - amount;
            }
            else
            {
                return false;
            }

        }
    

        public bool TransferMoney(long[] payeesAccount, double amount)
        {
            foreach (var item in payeesAccount)
            {
                DebitAmount(amount);
                return true;
            }
            return false;
        }
    
    public bool TransferMoney(String payees, double amount)
    {
        foreach(var item in payees)
        {
            DebitAmount(amount);
            return true;
        }
        return false;
    }

        internal void TransferMoney(long accountNo, int v)
        {
            throw new NotImplementedException();
        }
    }
     class Program
      {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            long accountNo =101;
            double bal =10000;
            String[] payees = { "harry", "hermoine" };
            long[] payeesAccount = { 123,456 };
            Account account = new Account(accountNo, bal);
            new Account(accountNo, bal, payees, payeesAccount);
            account.TransferMoney(accountNo, 5000);
            account.TransferMoney("harry", 2000);
        }
    }
}
