
namespace HotelApp.Models;

public class Room
{
    private static int  _idCounter = 0;
    public int Id { get;  }
    public string Name { get; set; }
    public double Price {  get; set; }
    public int PersonCapacity { get; set; }
    public bool isAvaileable { get; set; }


    public Room(string name, double price, int personCapacity)
    {
        int id = _idCounter++;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
        
    }

    public string ShowInfo()
    {
        return $"Room ID: {Id}\nName: {Name}\nPrice: {Price} AZN\nCapacity: {PersonCapacity} person(s)\nAvailable: {isAvaileable }";
    }


    public override string ToString()
    {
        return ShowInfo();
    }
}




