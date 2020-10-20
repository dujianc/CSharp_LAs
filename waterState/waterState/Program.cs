using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waterState
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperrature in Celsius: ");
            double temperature = double.Parse(Console.ReadLine());

            /*          if (temperature <= 0)
                      {
                          Console.WriteLine("The water state is solid (ice)");
                      }
                      else if (temperature > 0 && temperature < 100)
                      {
                          Console.WriteLine("The water state is liquid (water)");
                      }

                      else
                      {
                          Console.WriteLine("The water state is gas (steam)");

                      }  */


            string state = temperature <= 0 ? "solid (ice)" : (temperature < 100 ? "liquid (water)" : "gas (steam)");
           
            Console.WriteLine("The water state is {0}.", state);

            Console.ReadLine(); 
        }
    }
}
