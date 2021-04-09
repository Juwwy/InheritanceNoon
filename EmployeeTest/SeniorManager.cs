namespace EmployeeTest
{
    public class SeniorManager : Manager
    {
        public int Evaluation { get; set; }
        public decimal BonusSalary = 160M;
        public SeniorManager(string firstName, string lastName, decimal baseSalary, int evaluation) : base(firstName, lastName, baseSalary)
        {
            Evaluation = evaluation;
        }
        public override decimal CalculateSalary()
        {
            decimal newPay = 0;

            return Evaluation >=6 ? newPay = BaseSalary + BonusSalary : BaseSalary;


        }
    }   
}