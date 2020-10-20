using System;

namespace MyNamespace
{
	
	class Program
	{
		const float PI = 3.14159f;
		static void Main(string[] args)
		{

			float a, b,	gamma;
			Console.WriteLine("Enter the length side a: ");
			a = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter the length of side b: ");
			b = float.Parse(Console.ReadLine()); ;
			Console.WriteLine("Enter the angle gamma: ");
			gamma = float.Parse(Console.ReadLine());
			Console.WriteLine("The length of side c is " + CalcTriangleEdge(a, b, DegreesToRadians(gamma)));
			Console.ReadLine();
		}
		
		static float DegreesToRadians(float degrees)
		{
			return degrees * PI / 180.0f;
		}

		static float CalcTriangleEdge(float a, float b, float gamma)
		{
				return (float) Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(gamma));
			
		}
		
	}
}