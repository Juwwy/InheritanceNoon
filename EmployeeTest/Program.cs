using System;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Worker("Juwon", "Adeleke");
            var employee2 = new SeniorManager("Badmus", "Paul", 7);
            var employee3 = new SeniorManager("Gold", "Mariam", 3);
            var employee4 = new JuniorManager("Morolabi", "Arike", 123);
            var employee5 = new JuniorManager("Dave", "Matthew", 190);

            Console.WriteLine($"{employee1}\nMonth pay: {employee1.CalculateSalary():C}");
            Console.WriteLine($"{employee2}\nMonth pay: {employee2.CalculateSalary():C}");
            Console.WriteLine($"{employee3}\nMonth pay: {employee3.CalculateSalary():C}");
            Console.WriteLine($"{employee4}\nMonth pay: {employee4.CalculateSalary():C}");
            Console.WriteLine($"{employee5}\nMonth pay: {employee5.CalculateSalary():C}");
        }
    }
}
