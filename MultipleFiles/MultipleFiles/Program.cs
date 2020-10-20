using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create subclass objects
            SalariedEmployee salariedEmployee = new SalariedEmployee("Mahbub Murshed", "123-12-1357", 800.00);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Emmanuel Manarang", "111-22-3333", 16.75, 40);
            CommissionEmployee commissionEmployee = new CommissionEmployee("Dipti Gogoi", "444-44-4444", 10000, .06);
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Vinci Taylaran", "777-77-7777", 5000, .04, 300);

            Console.WriteLine("Employees processed individually:\n");
            Console.WriteLine(salariedEmployee);
            Console.WriteLine(hourlyEmployee);
            Console.WriteLine(commissionEmployee);
            Console.WriteLine(basePlusCommissionEmployee);

            //Create an Employee array
            var employees = new Employee[4];
            //Initialize array with different Employees
            employees[0] = salariedEmployee;
            employees[1] = hourlyEmployee;
            employees[2] = commissionEmployee;
            employees[3] = basePlusCommissionEmployee;

            Console.WriteLine("\nUtilise polymorphism to iterate across different employees:\n");

            //Process every element in the array
            foreach (var currentEmployee in employees)
            {

                // Check if employee is a BasePlusCommissionEmployee
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    // downcast Employee reference to BasePlusCommissionEmployee reference
                    BasePlusCommissionEmployee employee = (BasePlusCommissionEmployee)currentEmployee;
                    employee.BaseSalary = 1.30 * employee.BaseSalary;
                    Console.WriteLine("New base-salary with 30% increase is: $" + employee.BaseSalary);
                } // end if
                Console.WriteLine(currentEmployee); // invokes tostring    
            } // end for

            Console.WriteLine();
            // Get Employee type from employees array
            for (int j = 0; j < employees.Length; j++)
                Console.WriteLine("Employee {0} is {1}", j + 1, employees[j].GetType().Name);
            Console.Read();
        }
    }
}
