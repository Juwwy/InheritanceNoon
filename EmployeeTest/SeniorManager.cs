namespace EmployeeTest
{
    public class SeniorManager : Manager
    {
        public int Evaluation { get; set; }
        public SeniorManager(string firstName, string lastName, int evaluation) : base(firstName, lastName)
        {
            Evaluation = evaluation;
        }
        public override decimal CalculateSalary()
        {
            decimal newPay = 0;

            return Evaluation >=6 ? newPay = Salary + BonusSalary : Salary;


        }
    }   
}