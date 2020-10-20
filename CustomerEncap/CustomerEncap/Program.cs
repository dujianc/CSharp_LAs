using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEncap
{
	public class Customer
	{
		private string[] _name;
		private string _phone;
		public string Name
		{
			get
			{
				return _name[0][0] + ". " + _name[_name.Length - 1];
			}
			set
			{
				_name = value.Split(' ');
				do
				{
					if (_name.Length == 1 || _name.Length > 3)
					{
						Console.WriteLine("Please enter name in correct format!");
						_name = Console.ReadLine().Split();
					}
				} while (_name.Length == 1 || _name.Length > 3);
			}
		}

		public string Phone
		{
			get
			{
				return _phone.Substring(0, 3) + "-" + _phone.Substring(3, 3) + "-" + _phone.Substring(6, 4);
			}
			set
			{
				_phone = value;
				if(_phone.Length != 10)
                {
                    do
                    {
						if (_phone.Length != 10)
                        {
							Console.WriteLine("Please enter phone number in 10 digits format!");
							_phone = Console.ReadLine();
						}


					} while (_phone.Length != 10);
				}
			}
		}


		class Program
		{
			static void Main(string[] args)
			{
				Customer obj = new Customer();
				Console.WriteLine("Please enter your name:");
				obj.Name = Console.ReadLine();

				Console.WriteLine("Please enter your phone number:");
				obj.Phone = Console.ReadLine();

				//Console.WriteLine("Your name is:"+obj.Name);
				//Console.WriteLine("Your phone number is :" + obj.Phone);
				Console.WriteLine("Welcome "+ obj.Name +", your phone number is: " + obj.Phone +".");


				Console.ReadLine();
			}
		}
	}
}
