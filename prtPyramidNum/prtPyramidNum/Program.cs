using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prtPyramidNum
{
    
    class pyramidPattern
    {
        static void Main()
        {
            int i, j, n, k;

            Console.Write("Enter number of pyramid pattern height:");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = n-1; j >= i; j--)
                {
                    Console.Write("  ");
                }

                for (k = i-1; k >= -(i-1); k--)

                {
                    int m = i - Math.Abs(k);


                    Console.Write("{0,2}",m);
                }

                Console.WriteLine();

            }

            Console.Read();
        }
    }
}
