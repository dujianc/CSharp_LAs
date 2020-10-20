using System;

namespace Activity_5_2_3
{
    public class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Value { get; protected set; } = 0.0;
        public virtual void Deposit(double amount)
        {
            Value += amount;
        }
        public virtual void Withdraw(double amount)
        {
            Value -= amount;
        }
        public virtual void MonthEnd()
        {

        }
    }

    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public override void MonthEnd()
        {
            Value += Value * InterestRate;
        }
    }

    public class CheckingAccount : Account
    {
        public int TransactionLimit { get; set; }
        public int TransactionCount { get; private set; }
        public double TransactionFee { get; set; }
        public double AccountFee { get; set; }

        public override void Deposit(double amount)
        {
           base.Deposit(amount);
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            UpdateTransectionCount();

        }

        private void UpdateTransectionCount()
        {
            TransactionCount++;
        }

        public override void MonthEnd()
        {
            int eTransCount;
            if (TransactionCount> TransactionLimit)
            {
                eTransCount = TransactionCount - TransactionLimit;
                Value -= eTransCount * TransactionFee;
            }
            Value -= AccountFee;
            TransactionCount = 0;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Account mySavingsAccount = new SavingsAccount { ID = 5, Name = "My Savings Account", InterestRate = 0.01 }; //interest rate 1% per month
            mySavingsAccount.Deposit(100.0);
            mySavingsAccount.Withdraw(20.0);
            Console.WriteLine("Current Balance after all transections (Savings Account): " + mySavingsAccount.Value);
            mySavingsAccount.MonthEnd();
            Console.WriteLine("Balance after month end (Savings Account): " + mySavingsAccount.Value);




            Account myCheckingAccount = new CheckingAccount { ID = 7, Name = "My Checking Account", TransactionLimit = 2, TransactionFee = 1.5, AccountFee = 5.0 };
            myCheckingAccount.Deposit(100.0);
            myCheckingAccount.Withdraw(10.0);
            myCheckingAccount.Withdraw(10.0);
            myCheckingAccount.Withdraw(10.0);
            myCheckingAccount.Deposit(100.0);
            myCheckingAccount.Withdraw(20.0);
            Console.WriteLine("Current Balance after all transections (Checking Account): " + myCheckingAccount.Value);
            myCheckingAccount.MonthEnd();
            Console.WriteLine("Balance after month end (Checking Account):" + myCheckingAccount.Value);



            Console.ReadKey();
        }
    }

}
