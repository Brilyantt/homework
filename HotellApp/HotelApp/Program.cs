using HotelApp.Models;
using System.Runtime.InteropServices;

namespace HotelApp;

public class Program
{
    static void Main(string[] args)
    {
       Hotel roomm = null;
       Room createRoom = null;
        int choice;

       ;
        do
        {
            Console.WriteLine("\n===== Hotel Management System =====");
            Console.WriteLine("1. Otaq yarat");
            Console.WriteLine("2. Otaq elave et");
            Console.WriteLine("3. Rezerv et");
            Console.WriteLine("0. Cixis");
            Console.Write("Choose an option: ");

            bool input = int.TryParse(Console.ReadLine(), out choice);
            
            if (input)
            {
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Otaq adi elave edin:");
                        string roomName= Console.ReadLine();

                        Console.WriteLine("Otaq qiymeti daxil edin:");
                        double price ;
                        while (!double.TryParse(Console.ReadLine(), out price))
                        {
                            Console.WriteLine("Duzgun qiymet daxil edin");
                        }

                        Console.WriteLine("Insan sayini daxil edin:");
                        int capacity;
                        while (!int.TryParse(Console.ReadLine(), out  capacity))
                        {
                            Console.WriteLine("yeniden daxil edin:");
                        }

                        createRoom = new Room(roomName, price,capacity);
                        Console.WriteLine("Otaq yaradildi");
                        break;

                        case 2:
                        if (roomm == null)
                        {
                            Console.Write("Enter hotel name: ");
                            string hotelName = Console.ReadLine();
                            roomm = new Hotel(hotelName);
                        }

                        if (createRoom == null)
                        {
                            Console.WriteLine("1-ci secimi secin zehmet olmasa:)");
                        }
                        else
                        {
                            roomm.AddRoom(createRoom);
                            Console.WriteLine("Otaq elave edildi");
                            createRoom = null;  
                        }
                        break;

                        case 3:
                        if (roomm == null)
                        {
                            Console.WriteLine("Otaq yoxdur. Əvvəl otaq yaradıb əlavə edin.");
                            break;
                        }
                      
                        Room[] allrooms = roomm.GetAllRooms();

                        Console.WriteLine("Otaqlarin siyahis:");

                        foreach(Room room in allrooms)
                        {
                            Console.WriteLine(room);
                            Console.WriteLine("---------------------");
                        }

                        Console.WriteLine("Reverv ucun otaq id-si qeyd edin:");
                        int roomId;
                        if(int.TryParse(Console.ReadLine(),out roomId))
                        {
                            roomm.MakeReservation(roomId);
                        }
                        else
                        {
                            Console.WriteLine("Otaq id-si movcud deyil!");
                        }
                        break;


                        case 0:

                        Console.WriteLine("Cixis edilir..");
                        break ;
                        default:
                        Console.WriteLine("bele bir xidmet yoxdur.Yeniden yoxlayin");
                        break;

                }
            }

        }
        while (true);
    }
}
