namespace EmployeeTest
{
    public class Manager : Employee
    {
        public decimal Salary { get; set; } = 3000M;
        public decimal BonusSalary { get; set; }
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
            
        } 

        

        public override decimal CalculateSalary()
        {
            return Salary;
        }
        
    }
}