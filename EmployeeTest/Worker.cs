namespace EmployeeTest
{
    public class Worker : Employee
    {
        public int HoursWorked { get; set; } = 230;
        public decimal AmountPerHour { get; set;} = 130M;

        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {
            
        }

        public override decimal CalculateSalary()
        {
            return HoursWorked * AmountPerHour;
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }









        

        

    }
}