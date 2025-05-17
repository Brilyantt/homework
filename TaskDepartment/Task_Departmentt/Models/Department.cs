

using Task_Departmentt.Exceptions;

namespace Task_Departmentt.Models;

public class Department
{
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public Employee[] employees;
    public Department(string name, int employeeLimit)
    {
        Name = name;
        EmployeeLimit = employeeLimit;
        employees = new Employee[0];
    }

    public void AddEmployee(Employee employee)
    {
        if (employees.Length < EmployeeLimit)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
        }
        else
        {
            throw new CapacityLimitException("Yeteri qeder isci var");
        }
    }


    public Employee this[int index]
    {
        get
        {
            return employees[index]  ;
        }

        set
        {
            employees[index] = value ;
        }
    }
}
