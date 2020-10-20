using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
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

                    Console.WriteLine("Please enter integers in valid format!");
                }

            } while (flag==false);
             
            return x;

        }
        static void Main(string[] args)
        {

            Random obj = new Random();

            int hiddenNumber = obj.Next(1, 101);

            Console.WriteLine("Enter a number between 1 and 100 (inclusive)");

            int x;
            int count = 0;

            do
            {

                Console.Write("Guess: ");
                x = ValidIntegerInput();

                count++;

                if (hiddenNumber < x)
                {
                    Console.WriteLine("Lower!");
                 }
                    else if (hiddenNumber > x)
                    {

                    Console.WriteLine("Higher!");
                  
                }
                
            } while (hiddenNumber!=x);

            if (count == 1)
            {
                Console.Write("Correct! You used 1 guess");
             }
                else
                {
                  Console.Write("Correct! You used {0} guesses", count);

                }

               Console.Read();

        }
    }
}
