using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
	class Contact
    {
		public string Name { get; set; }
		public string Phone { get; set; }

		public void RecordDisplay()
        {
			Console.WriteLine("Name: " + Name + ", Phone Number: " + Phone+".");
        }

    }
	class Program
	{
		static void Display(List<Contact> myList)
		{
			Console.WriteLine("All records from the Contact List are as follows: ");
			
			foreach (var record in myList)
			{
				record.RecordDisplay();
			}
			Console.WriteLine();
		}

		static void Display(List<Contact> myList, string name)
		{
			Console.WriteLine("All records of : "+name);

			foreach (var record in myList)
			{
				record.RecordDisplay();
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			List<Contact> phoneList = new List<Contact>();

			string input;
			string[] split;

			do
			{
				Console.WriteLine("\nEnter a command: ");
				input = Console.ReadLine();
				input = input.ToLower();
				while (input.Contains("  ")) input = input.Replace("  ", " "); 
				input = input.Trim();   
				split = input.Split(' ');

				if (input.Length == 0) continue;
				else if (split[0].CompareTo("findall") == 0)
				{
					Display(phoneList);
				}
				else if (split[0].CompareTo("add") == 0)
				{
					string phone = split[split.Length - 1];

					string name = string.Join(" ", split, 1, split.Length - 2);

					phoneList.Add(new Contact() { Name = name, Phone = phone });
				}

				else if (split[0].CompareTo("delete") == 0)
				{
					string phone = split[1];
					Contact delNum = phoneList.Find(a => a.Phone == phone);
					phoneList.Remove(delNum);
				}

				else if (split[0].CompareTo("update") == 0)
				{
					string oldPhone = split[1];
					string newPhone = split[split.Length - 1];
					string newName = string.Join(" ", split, 2, split.Length - 3);

					Contact delNum = phoneList.Find(a => a.Phone == oldPhone);
					phoneList.Remove(delNum);
					phoneList.Add(new Contact() { Name = newName, Phone = newPhone });
				}
				else if (split[0].CompareTo("find") == 0)
                {
					string name= string.Join(" ", split, 1, split.Length - 1);
					List<Contact> allNumPerson = phoneList.FindAll(a => a.Name == name);
					Display(allNumPerson,name);
				}
				else
				{
					Console.WriteLine("Unknown command! \nPlease enter command in correct format...");
				}

			} while (input.CompareTo("exit") != 0);
						
		}
	}
}
