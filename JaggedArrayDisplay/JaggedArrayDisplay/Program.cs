using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayDisplay
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
					a[i, j] = r.Next(1, 10);
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
					Console.Write(string.Format("{0,3}", a[i, j]) + " ");   // 0-parameter 3-width
				}
				Console.WriteLine();
			}
		}

		static void ShowJaggedArray(int[][] b)
		{
			int i, j;
			for (i = 0; i < b.GetLength(0); i++)
			{
				for (j = 0; j < b[i].GetLength(0); j++)
				{
					Console.Write(string.Format("{0,3}", b[i][j]) + " ");   // 0-parameter 3-width
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
			a = new int[m, n];
			Console.WriteLine("Enter Random Seed Number: ");
			int seed = int.Parse(Console.ReadLine());
			Populate(a, seed);
			Console.WriteLine("Array Elements: ");
			ShowArray(a);

			int[][] ja2D = new int[][]
			{
			new int[] { 7 },
			new int[] { 1, 3, 7, 9, 11 },
			new int[] { 1, 2, 3, 4, 5, 6, 7 }
		    };

			Console.WriteLine("Jagged Array Elements: ");
			ShowJaggedArray(ja2D);

			int[][,] ja3D = new int[3][,]
			{
				new int[,] { {1,2} },
				new int[,] { {1,4}, {4,8}, {7,12} },
				new int[,] { {3,2,1,0}, {5,5,4,3}}
			};

			Console.WriteLine(ja3D.Length);
			Console.WriteLine(ja3D[1].GetLength(0));
			Console.WriteLine(ja3D[2].GetLength(1));

			Console.Read();
		}
	}
}
