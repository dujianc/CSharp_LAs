using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLA
{
	class Employee  // Starter Code
	{
		// ToDo Set Private Data Field
		private string _name;
		private double _wage;
		private double _hours;
		private double _amountDue;

		public Employee()
        {
			_name = "";
			_wage = 0;
			_hours = 0;
			_amountDue = 0;

        }

		public void SetName(string name)
		{ // ToDo
			_name = name;
		}
		public string GetName()
		{ // ToDo
			return _name;
		}
		public void SetWage(double rate)
		{ // ToDo
			_wage = rate;

		}
		public void Work(double hours)
		{ // ToDo
			_hours += hours;
			_amountDue = _hours * _wage;
		}
		public double Pay()
		{ // ToDo
			_hours = 0;
			return _amountDue;

		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			// create two employee objects

			Employee emp1 = new Employee();
			Employee emp2 = new Employee();

			emp1.SetName("David");
			emp1.SetWage(15);
			emp2.SetName("Susan");
			emp2.SetWage(20);

			Console.WriteLine("Employee '{0}' is paid {1} before working...", emp1.GetName(), emp1.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} before working...", emp2.GetName(), emp2.Pay());
			emp1.Work(5);
			emp2.Work(8);
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.GetName(), emp1.Pay());

			emp1.Work(5);
			emp2.Work(2);
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.GetName(), emp1.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp2.GetName(), emp2.Pay());
			Console.Read();
		}
	}
}
