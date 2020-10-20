using System;

namespace ProgrammingFundamentals
{
	class Program
	{
		static void FormatName(ref string name, string title)   
		{
			
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a Full Name: ");
			string name = Console.ReadLine();
			Console.WriteLine("Enter a Professional Title: ");
			string title = Console.ReadLine();

			FormatName(ref name, title);
			Console.WriteLine("The formatted name is: " + name);

			Console.ReadLine();
		}
	}
}
