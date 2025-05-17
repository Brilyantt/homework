
namespace Task_Departmentt.Models
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age     { get; set; }
        string ShowInfo();
    }
}
