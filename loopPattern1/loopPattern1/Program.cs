using System;

namespace Programming_Fundamentals
{
	class Program
	{

		public static void Main()
		{
			Console.Write("Pascal's triangle:\n");
			Console.Write("-----------------");
			Console.Write("Input number of rows: ");
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++) // n rows
			{
				for (int j = 1; j <= n - i; j++)
					Console.Write(" "); //prints leading space chars
				for (int c = 1, j = 0; j <= i; j++) //row-1, print 1 item, row-2, print 2 items, and so on
				{
					if (j == 0) //begin every row with c = 1
						c = 1;
					else
						c = c * (i - j + 1) / j;
					Console.Write("{0,5} ", c);
				}
				Console.Write("\n");
			}
			Console.Read();
		}
	}
}