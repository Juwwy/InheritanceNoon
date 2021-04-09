namespace EmployeeTest
{
    public class JuniorManager : Manager
    {
        public decimal BonusSalary = 50M;
        public int HoursWorked { get; set; }
        public JuniorManager(string firstName, string lastName, decimal baseSalary, int hoursWorked) : base(firstName, lastName, baseSalary)
        {
            HoursWorked = hoursWorked;

        }

        public override decimal CalculateSalary()
        {
            decimal newPay = 0.0M;
            return HoursWorked >= 180 ? newPay = BaseSalary + BonusSalary : BaseSalary;
            
        }
    }
}