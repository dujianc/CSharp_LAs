using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPerfectNumber
{
	class Program
	{
		static bool Perfect(int n)
		{
			int sum = 0;
			foreach (var divisor in Enumerable.Range(1, n / 2))
			{
				if (n % divisor == 0)
					sum += divisor;
			}
			if (sum == n) return true;
			else return false;
		}
		static void Main(string[] args)
		{
			int[] arr = new int[] { 2, 4, 6, 12, 18, 25, 28, 40, 60, 71, 496, 789, 5000, 8128, 1622 };
			foreach (var number in arr)
			{
				if (Perfect(number))
					Console.WriteLine("Perfect Number: " + number);
			}
			Console.Read();
		}
	}
}
