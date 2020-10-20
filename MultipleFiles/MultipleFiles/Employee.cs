namespace MultipleFiles
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Ssn { get; set; }

        // two-argument constructor
        public Employee(string name, string ssn)
        {
            Name = name;
            Ssn = ssn;
        }

        //Overriding System Object class method...
        public override string ToString()
        {
            return Name + "\nSocial security number: " + Ssn;

        }

        // abstract method overridden by concrete subclasses        
        public abstract double earnings();
        // no implementation is allowed here, derived calss must override this method!
    } // end abstract class Employee
}
