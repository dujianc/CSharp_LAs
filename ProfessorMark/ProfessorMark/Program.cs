using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorMark
{
	class Program
	{
		static void Populate(double[] a, int seed)
		{
			Random r = new Random(seed);
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = r.NextDouble() * 50.0 + 50.0;
				Console.Write(string.Format("{0:0.0}", a[i]) + ", ");
			}
			Console.WriteLine("\b\b ");
		}
		static double[] ArrayInput(int i, int seed)
		{
			int n;
			double[] a;
			Console.WriteLine("How many students in subject {0}?", i + 1);
			n = int.Parse(Console.ReadLine());
			a = new double[n];
			Console.WriteLine("Random Marks for subject {0}:", i + 1);
			Populate(a, seed);
			return a;
		}

		static double ComputeAverage(double[] a)
		{
			double sum = 0;
			for (int i = 0; i < a.Length; i++)
			{
				sum += a[i];
			}
			return sum / a.Length;
		}
		static void Main(string[] args)
		{
			int sub;
			Console.WriteLine("How many subjects? ");
			sub = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Random Seed Number: ");
			int seed = int.Parse(Console.ReadLine());
			double[][] ja2D = new double[sub][];
			for (int i = 0; i < sub; i++)
			{
				ja2D[i] = ArrayInput(i, seed);
			}
			for (int i = 0; i < sub; i++)
			{
				Console.WriteLine("Subject: {0}, Students: {1}, Average: " + string.Format("{0:0.0}", ComputeAverage(ja2D[i])), i + 1, ja2D[i].Length);
			}
			Console.Read();
		}
	}
}
