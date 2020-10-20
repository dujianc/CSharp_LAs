namespace MultipleFiles
{
    public partial class BasePlusCommissionEmployee : CommissionEmployee
    {
        public double BaseSalary { get; set; }
        // five-argument constructor
        public BasePlusCommissionEmployee(string name, string ssn, double sales, double rate, double salary) : base(name, ssn, sales, rate)
        {
            BaseSalary = salary; // set base salary
        } // end five-argument BasePlusCommissionEmployee constructor

        // calculate earnings; override method earnings in CommissionEmployee
        //@Override                                                            
                                                  
    } // end class BasePlusCommissionEmployee
}
