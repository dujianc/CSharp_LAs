using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFiles
{
    public partial class BasePlusCommissionEmployee : CommissionEmployee
    {
        public override double earnings()
        {
            return BaseSalary + base.earnings();
        }// end method earnings                                              

        // return string representation of BasePlusCommissionEmployee object
        //@Override                                                           
        public override string ToString()
        {

            string s = "Base-salaried-commission employee: " + Name + "\n" + "Social security number: " + Ssn +
                "\nGross sales " + string.Format("${0:0.00}", GrossSales) + "; Commission rate " + string.Format("${0:0.00}", CommissionRate) + "; Base salary " + string.Format("${0:0.00}", BaseSalary) + string.Format("\nEarned ${0:0.00}", earnings());
            return s;
        } // end method tostring 
    }
}
