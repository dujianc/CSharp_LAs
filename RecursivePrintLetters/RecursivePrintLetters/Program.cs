using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePrintLetters
{
    class Program
    {
        static void Display(int n)
        {
            if (n == 0) return;
            Display(n - 1);
            Console.Write((char)('A' +n-1) + " ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            Display(n);
            Console.Read();
        }
    }
}
