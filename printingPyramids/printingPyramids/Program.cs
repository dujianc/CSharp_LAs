using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Write(" ");
            }

            for (k = 1; k <= i; k++)

            {
                Console.Write("* ");
            }

            Console.WriteLine();
                       
        }

        Console.Read();
    }
}