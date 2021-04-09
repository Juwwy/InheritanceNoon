namespace EmployeeTest
{
    public abstract class Manager : Employee
    {
        // protected decimal salary;
        // public decimal BonusSalary { get; set; }
        private decimal baseSalary;
        public decimal BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }
        
        public Manager(string firstName, string lastName, decimal baseSalary) : base(firstName, lastName)
        {
            BaseSalary = baseSalary;
        } 

        

        

        
       
        
    }
}