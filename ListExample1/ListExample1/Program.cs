using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> intList = new List<int>();
			intList.Add(2);
			intList.Add(3);
			intList.Add(5);
			intList.Add(7);
			intList.Add(13);
			intList.Add(17);
			intList.Add(19);
			Console.WriteLine("List elements:");
			foreach (int prime in intList)
			{
				// iterate over a collection
				Console.Write(prime + " ");
			}

			intList.Reverse();
			Console.WriteLine("\nList elements reversed:");
			for (int i = 0; i < intList.Count; i++)
			{
				// access a list as an array
				Console.Write(intList[i] + " ");
			}

			intList.Insert(1, 11);
			intList.Remove(5);
			intList.Add(23);
			Console.WriteLine("\nUpdated list after addition, insertion and deletion:");
			foreach (int prime in intList)
			{
				// iterate over a collection
				Console.Write(prime + " ");
			}

			intList.Sort();
			Console.WriteLine("\nList elements after sorting:");
			foreach (int prime in intList)
			{
				// iterate over a collection
				Console.Write(prime + " ");
			}
			Console.Read();
		}
	}
}
