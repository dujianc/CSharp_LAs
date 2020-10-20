using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNumbers
{
    class Program
    {
        static int ValidIntegerInput() 
        {
            bool flag;
            int x;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out x);
                if (flag == false)
                {
                    Console.WriteLine("Please enter a valid integer!");
                }
            }
            while (flag == false);

            return x;
        }

        static char ValidChoiceInput()
        {
            bool flag;
            char x;
            do
            {
                flag = char.TryParse(Console.ReadLine(), out x);
                if (flag == false)
                {
                    Console.WriteLine("Calculate another sum ?(Y/N)");
                }
            }
            while (flag == false);

            return x;
        }

        static void Main(string[] args)
        {

            char c;
            do
            {
                Console.WriteLine("Please enter integers. Enter 0 to stop input");
                int x;
                int sum = 0;

                do
                {
                    x = ValidIntegerInput();

                    sum = sum + x;

                } while (x != 0);

                Console.WriteLine("Summation: " + sum);

                Console.WriteLine("Calculate another sum ?(Y/N)");

                c = ValidChoiceInput();


            } while (c=='y' || c=='Y' );

            Console.Read();


        }
    }
}
