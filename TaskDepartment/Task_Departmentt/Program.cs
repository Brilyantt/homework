using Task_Departmentt.Models;

namespace Task_Departmentt;

public class Program
{
    static void Main(string[] args)
    {

        Department finance = new Department("Finance", 6);

        Employee employee = new Employee("Brilyant", 22, 1200);
        Employee employee2 = new Employee("Aylin", 24, 1500);
        Employee employee3 = new Employee("Cefer", 28, 1800);

        finance.AddEmployee(employee);
        finance.AddEmployee(employee2);
        finance.AddEmployee(employee3);

        Console.WriteLine(finance[0]);
        Console.WriteLine(finance[1]);
        Console.WriteLine(finance[2]);

        
    }
}
