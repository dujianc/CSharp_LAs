using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDarrayTemp
{
	class Program
	{
		static void Populate(int[,] a, int seed)
		{
			Random r = new Random(seed);
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] = r.Next(1, 100);
				}
			}
		}
		static void ShowArray(int[,] a)
		{
			int i, j;
			for (i = 0; i < a.GetLength(0); i++)
			{
				for (j = 0; j < a.GetLength(1); j++)
				{
					Console.Write(string.Format("{0,3}", a[i, j]) + " "); 
				}
				Console.WriteLine();
			}
		}
		
		public static void Main()
		{
			int[,] a;
			int m, n;
			Console.WriteLine("Enter Array Size \'m\': ");
			m = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Array Size \'n\': ");
			n = int.Parse(Console.ReadLine());
			a = new int[m+1, n+1];
			Console.WriteLine("Enter Random Seed Number: ");
			int seed = int.Parse(Console.ReadLine());
			Populate(a, seed);
			Console.WriteLine("Array Elements of \'A\': ");
			ShowArray(a);
			Console.Read();
		}
	}
}
