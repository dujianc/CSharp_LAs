using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclassPrime3
{
    class Program
    {
        static void Display(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }
        static bool ReplaceANumber(int[] x, int num)
        {
            int i, j;
            for (i = 0; i < x.Length; i++)
            {
                if (x[i] == num)
                {
                    //found a number
                    for (j = i; j < x.Length - 1; j++)  //at step j we are accessing j+1 for iterate one less than size 
                    {
                        x[j] = x[j + 1];
                    }
                    //all remaining values are repositioned, therefore add a zero at the end
                    x[j] = 0;
                    return true;  //meaning we have replaced one; there might be more...
                }
            }
            //we are here, meaning we found no other number to replace; therefor all numbers are replaced.
            return false;
        }
        static int RemoveFromArray(int[] x, int num)
        {
            int count = 0;
            while (ReplaceANumber(x, num) == true)
            {
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] x = new int[20];   //change me to accommodate more size          

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(1, 21);
            }
            Console.WriteLine("Original Array: ");
            Display(x);
            Console.WriteLine("Please enter a number to remove: ");
            int num = int.Parse(Console.ReadLine());
            int times = RemoveFromArray(x, num);
            Console.WriteLine("Replaced {0} time(s). After Replace Array Elements: ", times);
            Display(x);

            Console.Read();
        }

    }
}
