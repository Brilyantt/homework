
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace HotelApp.Models;

public class Hotel
{
    public string Name { get; set; }
    private Room[] rooms;

    public Hotel(string name)
    {
        name = Name;
        rooms = new Room[0];
    }

    public void AddRoom(Room room)
    {
        Array.Resize(ref rooms, rooms.Length +1);
        rooms[rooms.Length-1] = room;
    }

    public void MakeReservation(int roomId)
    {
        Room  foundRoom = null; 
         foreach (Room room in rooms)
        {
            if(room.Id == roomId)
            {
                foundRoom = room;
                break;
            }
        }
         if (foundRoom == null)
        {
            Console.WriteLine("Otaq movcud deyil");
            return;
        }

        if (!foundRoom.isAvaileable)
        {
            Console.WriteLine("butun otaqlar doludur");
        }
        else
        {
            foundRoom.isAvaileable = false;
            Console.WriteLine("rezervasiya ugurlu oldu");
        }        
    }

    public Room[] GetAllRooms()
    {
        return rooms;
    }
}
