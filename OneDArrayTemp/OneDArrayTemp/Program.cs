using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExamples
{
	class Program
	{
		
		static void ShowArray(float[] a)
		{
			int i;
			for (i = 0; i < a.Length; i++)
			{
				if (i % 30 == 0) Console.WriteLine();
				Console.Write(string.Format("{0:0.0}", a[i]) + " ");
			}
		}
		public static void Main()
		{
			float[] a;
			Random r = new Random();
			Console.WriteLine("Enter Array Size: ");
			int n = int.Parse(Console.ReadLine());
			a = new float[n];
			for (int i = 0; i < n; i++)
			{
			a[i] = (float)r.NextDouble() * 100.0f;  // NextDouble() returns double value in range 0.0 to 1.0.
			}
			Console.Write("Elements of the array: ");
			ShowArray(a);
						
			Console.Read();
		}
	}
}
