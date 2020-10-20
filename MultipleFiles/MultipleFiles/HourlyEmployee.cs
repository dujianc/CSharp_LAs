namespace MultipleFiles
{
    public class HourlyEmployee : Employee
    {
        public double Wage { get; set; } // wage per hour

        private double _hours;
        public double Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value >= 0.0 && value <= 168.0)
                    _hours = value;
                else
                    _hours = 0;

            }
        }
        // four-argument constructor
        public HourlyEmployee(string name, string ssn, double hourlyWage, double hoursWorked) : base(name, ssn)
        {
            Wage = hourlyWage; // set hourly wage
            Hours = hoursWorked; // set hours worked
        }

        // calculate earnings; override abstract method earnings in Employee
        //@Override                                                           
        public override double earnings()
        {
            if (Wage <= 40) // no earning for less than 40 hours of overtime overtime
                return Wage * Hours;
            else
                return 40 * Wage + (Hours - 40) * Wage * 1.5; //overtime earning is 1.5 times regualr pay..
        } // end method earnings                                            

        // return string representation of HourlyEmployee object              
        //@Override                                                             
        public override string ToString()
        {
            string s = "Hourly employee: " + base.ToString() + "\nHourly wage " + string.Format("${0:0.00}", Wage + "; Hours worked " + Hours + string.Format("\nEarned ${0:0.00}", earnings()) + "\n");
            return s;
        } // end method tostring                                              
    } // end class HourlyEmployee
}
