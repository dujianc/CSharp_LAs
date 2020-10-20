using System;
using System.Threading;
using System.Collections.Generic;

class MainClass
{
    // declare random number generator
    static Random r = new Random();

    public static void Main(string[] args)
    {

        // transactions to be performed
        List<Func<int, bool>> transactions = new List<Func<int, bool>>();

        // rollbacks to be performed
        List<Func<bool>> rollbacks = new List<Func<bool>>();

        int maxNumTries = 3; // number of tries to attempt each part
        bool flag;           // flag advises success of complete transaction

        Console.WriteLine("Transaction Management\n");

        // transactions to be attempted in sequential order
        transactions.AddRange(new Func<int, bool>[] {
      CalculateTotal,
      UpdateCouponUsage,
      ChargeVendorProcessingFee,
      ChargeCreditCard
    });

        // rollbacks to be performed in case transaction fails
        rollbacks.AddRange(new Func<bool>[] {
      RollbackCalculateTotal,
      RollbackUpdateCouponUsage,
      RollbackChargeVendorProcessingFee,
      RollbackChargeCreditCard
    });

        flag = CompleteTransactions(transactions, rollbacks, maxNumTries);
        Console.WriteLine("Transaction Finished: Succeed = " + flag);
    }


    // method to attempt an entire list of transactions
    public static bool CompleteTransactions(List<Func<int, bool>> transactions,
      List<Func<bool>> rollbacks, int maxNumTries)
    {
        //Func<int, bool> transaction = new Func<int, bool>();
        bool flag = false;
        int count = 0; // number of transactions that succeeded
        foreach (Func<int, bool> transaction in transactions)
        {
            flag = AttemptTransaction(transaction, maxNumTries);
            if (flag == false) break; else count++;
        }
        // check if the complete transaction failed and
        // if any individual transactions need to be rolled back.
        if (flag == false && count > 0)
        {
            for (int i = count - 1; i > 0; i--)
            {
                rollbacks[i]();
            }
        }
        return flag;
    }

    // method to attempt indivisible transaction
    public static bool AttemptTransaction(Func<int, bool> f, int attempts)
    {
        bool flag;           // ultimate success or failure of transaction
        int count = 0;       // count of attempts beginning at 0
        do
        {
            flag = f(count);   // attempt the transaction, let it know what attempt this is
            if (flag == true) Console.Write("Succeeded"); else Console.Write("Failed");
            count++;           // increment count of attempts

            // if failed & still more tries remaining, execute Retry() delay
            if (flag == false && count < attempts)
            {
                Console.Write("... ");
                Retry();
            }
        } while (flag == false && count < attempts);

        // transaction completed
        Console.WriteLine(".");
        return flag;         // return ultimate status
    }


    public static void Retry()
    {
        Thread.Sleep(3000);  // pause for 3 seconds
    }


    public static bool CalculateTotal(int attempt)
    {
        if (attempt == 0)
        {    // first try
            Console.Write("Attempting to Calculate Total... ");
        }
        return RandomSuccess();
    }

    public static bool RollbackCalculateTotal()
    {
        Console.WriteLine("Rolled Back Total Calculation.");
        return true;
    }


    public static bool UpdateCouponUsage(int attempt)
    {
        if (attempt == 0)
        {    // first try
            Console.Write("Attempting to Update Coupon... ");
        }
        return RandomSuccess();
    }

    public static bool RollbackUpdateCouponUsage()
    {
        Console.WriteLine("Rolled Back Coupon Update.");
        return true;
    }


    public static bool ChargeVendorProcessingFee(int attempt)
    {
        if (attempt == 0)
        {    // first try
            Console.Write("Attempting to Charge Vendor Processing Fee... ");
        }
        return RandomSuccess();
    }

    public static bool RollbackChargeVendorProcessingFee()
    {
        Console.WriteLine("Rolled Back Charge of Vendor Processing Fee.");
        return true;
    }


    public static bool ChargeCreditCard(int attempt)
    {
        if (attempt == 0)
        {    // first try
            Console.Write("Attempting to Charge Credit Card... ");
        }
        return RandomSuccess();
    }

    public static bool RollbackChargeCreditCard()
    {
        Console.WriteLine("Rolled Back Charge to Credit Card.");
        return true;
    }


    public static bool RandomSuccess()
    {
        return (r.Next(0, 10) < 5);
    }
        
}