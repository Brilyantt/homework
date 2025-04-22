namespace NotAvailableException.Models;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    private List<Room> roomLists { get; set; }

    public Hotel(string name)
    {
        Name = name;
    }

    public void AddRoom(Room room)
    {
        roomLists.Add(room);
    }

    public List<Room> FindAllRoom()
    {
        foreach (var room in roomLists)
        {
        }
        return roomLists;
    }

    public void MakeReservation()
    {
        int? roomId = null;
        int? countOfCustomer = null;

        if (roomId is null)
        {
            throw new NullReferenceException("Rood Id bos ola bilmez");

        }


    }
}
