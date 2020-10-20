using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals
{
	class Program
	{
		static int GetQuarters(int cents)
		{
			int remainder = cents % 25;
			int quarters = (cents - remainder) / 25;
			return quarters;
		}

		static int GetDimes(int cents)
		{
			int dimes = cents / 10;
			return dimes;
		}

		static int GetNickels(int cents)
		{
			int nickels = cents / 5;
			return nickels;
		}

		static int GetPennies(int cents)
		{
			return cents;
		}

		static void Main(string[] args)
		{
			int cents;
			Console.WriteLine("How much change do you need? ");
			cents = int.Parse(Console.ReadLine());
			int quarters = GetQuarters(cents);
			cents -= quarters * 25;
			int dimes = GetDimes(cents);
			cents -= dimes * 10;
			int nickels = GetNickels(cents);

			cents -= nickels * 5;

			int pennies = GetPennies(cents);
			
			cents -= pennies * 1;

			Console.WriteLine("Quarters: " + quarters);
			Console.WriteLine("Dimes: " + dimes);
			Console.WriteLine("Nickels: " + nickels);
			Console.WriteLine("Pennies: " + pennies);

			Console.Read();
		}
	}
}