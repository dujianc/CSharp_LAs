using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace PiCalculator
{
    class PiCalculator
    {
        static void Main(string[] args)
        {
            const double piGood = 3.14159265;
            double pi_over_4 = 0;
            double piDiff = 3.14159265;
            double pi = 0;

            Console.Write("Please enter the initial number of terms: ");
            int num_ini = int.Parse(Console.ReadLine());
            int num_terms = num_ini;
            double sign = 1;

            while (piDiff > 0.00001)
            {
                pi_over_4 = 0;

                for (int term = 0; term < num_terms; term++)
                {
                    pi_over_4 += sign / (term * 2 + 1);
                    sign *= -1;
                }

                pi = 4 * pi_over_4;
                piDiff = Math.Abs(pi - piGood);
                num_terms++;

            }

            Console.WriteLine("The final number of terms is: " + num_terms);
            Console.WriteLine("The estimated Pi is: " + pi);

            Console.ReadLine();
        }
    }
}