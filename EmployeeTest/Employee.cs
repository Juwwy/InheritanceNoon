namespace EmployeeTest
{
    public abstract class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
           
        }

        

        public abstract decimal CalculateSalary();

        public override string ToString()
        {
            return $"\n{FirstName} {LastName}\n";
        }
    }
}