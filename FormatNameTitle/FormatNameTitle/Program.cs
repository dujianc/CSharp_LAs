using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNameTitle
{
	class Program
	{
		static void FormatName(ref string name, string title)
		{
			string[] nameParts = name.Split(' ');
			name = title + " " + nameParts[nameParts.Length - 1]+" ";
			for(int i=0; i<nameParts.Length-1; i++)
            {
				name += nameParts[i][0] + ". ";
            }
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
