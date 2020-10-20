using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meter_To_Foot
{
    class Program
    {
        const double METER_TO_FEET = 3.28084d;

        static double MeterTofeet(double metre)
        {
            return metre * METER_TO_FEET;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value in Meter: ");
            double metre = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} meter(s) is equal to {1} feet(s)", metre, MeterTofeet(metre));
            Console.ReadLine();

        }
    }
}
