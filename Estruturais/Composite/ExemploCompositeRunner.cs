using Estruturais.Composite;

namespace Estruturais
{
    public class ExemploCompositeRunner
    {
        public static void Run(string[] args)
        {
            // Composite
            var devTeam = new Department("Development Team");
            devTeam.Add(new Employee("Alice", 80000));
            devTeam.Add(new Employee("Bob", 90000));

            var qaTeam = new Department("QA Team");
            qaTeam.Add(new Employee("Charlie", 70000));

            var techDepartment = new Department("Tech Department");
            techDepartment.Add(devTeam);
            techDepartment.Add(qaTeam);
            techDepartment.Add(new Employee("Dave", 120000)); 

            Console.WriteLine($"Total salary for {techDepartment.GetName()}: ${techDepartment.CalculateTotalSalary()}");

            Console.ReadKey();
        }
    }
}