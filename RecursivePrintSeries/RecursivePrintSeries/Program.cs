using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePrintSeries
{
    class Program
    {
        static int XpowN(int x, int n)
        {
            if (n == 0) return 1;
            return x * XpowN(x, n - 1);
        }

        static int ComputeSum(int x, int n)
        {
            if (n == -1) return 0;
            int sum = XpowN(x, n) + ComputeSum(x, n - 1);
            Console.Write(XpowN(x, n)+"+");
            return sum;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\b="+ComputeSum(x,n));
            Console.Read();

        }
    }
}
