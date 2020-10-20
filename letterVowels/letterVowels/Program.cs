using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letterVowels
{

	class program
    {
   
		static void Main(string[] args)
	{
		Console.WriteLine("Please enter a letter (lowercase or uppercase): ");
			char c = char.Parse(Console.ReadLine());
			c = char.ToLower(c);
					
		switch (c)
		{
				case 'a':
				case 'e':
				case 'i':
				case 'o':
				case 'u':
				  Console.WriteLine("This is a vowel");
				  break;

				case 'y':
				  Console.WriteLine("This is sometime a vowel");
				  break;


				default:
				Console.WriteLine("This is not a vowel but a consonant.");
				break;
		}

		Console.ReadLine();
	}

	}
}