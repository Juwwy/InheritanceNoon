namespace EmployeeTest
{
    public class JuniorManager : Manager
    {
        public int HoursWorked { get; set; }
        public JuniorManager(string firstName, string lastName, int hoursWorked) : base(firstName, lastName)
        {
            HoursWorked = hoursWorked;

        }

        public override decimal CalculateSalary()
        {
            decimal newPay = 0.0M;
            return HoursWorked >= 180 ? newPay = Salary + BonusSalary : Salary;
            
        }
    }
}