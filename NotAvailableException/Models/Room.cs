namespace NotAvailableException.Models;

public class Room
{
    private static int _counter = 0;

    public int Id { get; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int PersonCapacity { get; set; }
    public bool IsAvialable { get; set; }



    public Room(string name, double price, int personCapacity)
    {
        _counter++;
        Id = _counter;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
        IsAvialable = true;
    }

    public string ShowIonfo()
    {
        Console.WriteLine($"Name: {Name},\nPrice:{Price},\n personOfCount: {PersonCapacity}");

        return null;

    }
    public override string ToString()
    {
        return ShowIonfo();
    }
}
