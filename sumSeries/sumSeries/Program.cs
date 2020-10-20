using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace SumSeries
{
    class SumSeries
    {
         static double factorial_Recursion(int number)
        {
            if (number == 1)
            { return 1; }
            else
            {
              return number * factorial_Recursion (number - 1);
            }
        
        }

         static void Main(string[] args)
            {
                double sum = 0;
                Console.Write("Please enter the number of terms: ");
                int num_terms = int.Parse(Console.ReadLine());
            
                Console.Write("Please enter X: ");
                double x = double.Parse(Console.ReadLine());

                double sign = 1;
                
                for (int i = 1; i <= num_terms; i++)
                {
                double aa = Math.Pow(x, (i * 2 - 1));
                double bb = factorial_Recursion((i * 2) - 1);
                double cc = aa / bb;
                sum += sign * (aa / bb);
                sign *= -1;

                if (i == 1) { Console.Write(String.Format("{0:0.00}", cc)); }
                
                if(i > 1 && i != num_terms && sign == 1) 
                {
                Console.Write(" - ");
                Console.Write(String.Format("{0:0.00}",cc));
                
                }

                if (i > 1 && i != num_terms && sign == -1)
                {
                    Console.Write(" + ");
                    Console.Write(String.Format("{0:0.00}", cc));
                 
                }

                if (i == num_terms && sign==1) {
                    Console.Write(" - ");
                    Console.Write(String.Format("{0:0.00}", cc));
                    Console.Write(" = ");
                }

                if (i == num_terms && sign == -1)
                {
                    Console.Write(" + ");
                    Console.Write(String.Format("{0:0.00}", cc));
                    Console.Write(" = ");
                }

               }
                               
                Console.Write(String.Format("{0:0.00}", sum));

                Console.ReadLine();
            }
    }
}



   

