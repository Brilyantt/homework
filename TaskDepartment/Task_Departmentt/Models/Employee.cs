

namespace Task_Departmentt.Models;

public class Employee : IPerson
{
    private static int _idCounter = 0;
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        _idCounter++;
        Id = _idCounter;
        Name = name;
        Age = age;
        Salary = salary;
    }
    public string ShowInfo()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
    }

    public override string ToString()
    {
        return ShowInfo();
    }

}
