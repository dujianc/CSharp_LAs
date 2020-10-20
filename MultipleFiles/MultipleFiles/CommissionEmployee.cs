namespace MultipleFiles
{
    public class CommissionEmployee : Employee
    {
        private double _grossSales; // gross weekly sales
        public double GrossSales
        {
            get
            {
                return _grossSales;
            }
            set
            {
                if (value >= 0.0)
                    _grossSales = value;
                else
                    _grossSales = 0;

            }
        }

        public double CommissionRate { get; set; } // commission percentage

        // four-argument constructor
        public CommissionEmployee(string name, string ssn, double sales, double rate) : base(name, ssn)
        {

            GrossSales = sales;
            CommissionRate = rate;
        }

        // calculate earnings; override abstract method earnings in Employee
        //@Override                                                           
        public override double earnings()
        {
            return CommissionRate * GrossSales;
        } // end method earnings                                            

        // return string representation of CommissionEmployee object
        //@Override                                                   
        public override string ToString()
        {

            string s = "Commission employee: " + base.ToString() + "\nGross sales " + string.Format("${0:0.00}", GrossSales) + "; Commission rate " + string.Format("${0:0.00}", CommissionRate + string.Format("\nEarned ${0:0.00}", earnings()) + "\n");
            return s;
        } // end method tostring                                    
    } // end class CommissionEmployee
}
