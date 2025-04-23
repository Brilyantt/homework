namespace NotAvailableException.Models;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    private List<Room> roomLists { get; set; }

    public Hotel(string name)
    {
        Name = name;
        roomLists = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        roomLists.Add(room);
    }

    public Room? FindAllRoom(int id)
    {
        foreach (Room room in roomLists)
        {
            if (room.Id == id)
            {
                return room;
            }
        }

        return null;
    }

    public void MakeReservation(int? roomId, int? countOfCustomer)
    {
        if (roomId is null || countOfCustomer is null)
        {
            throw new NullReferenceException("Rood Id bos ola bilmez");

        }

        var findRoom = roomLists.Find(item => item.Id == roomId);

        if (findRoom is not null)
        {
            foreach (Room item in roomLists)
            {
                if (item.IsAvialable == false)
                {
                    throw new NullReferenceException("Rood Id bos ola bilmez");
                }
                else
                {
                    if (item.PersonCapacity == countOfCustomer)
                    {
                        item.IsAvialable = true;
                    }
                }
            }
        }
    }
}
