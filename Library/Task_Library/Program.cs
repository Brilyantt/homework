using Task_Library.Models;

namespace Task_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            string choice;

            do
            {
                Console.WriteLine("\n--- MENYU ---");
                Console.WriteLine("1. Kitab əlavə et");
                Console.WriteLine("2. ID-ə görə kitab tap");
                Console.WriteLine("3. Kitabı sil");
                Console.WriteLine("4. Kitabı yenilə");
                Console.WriteLine("5. Bütün kitabları göstər");
                Console.WriteLine("0. Çıxış");


                Console.Write("Seçiminizi edin: ");
                choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Kitabın adını daxil edin: ");
                        string name = Console.ReadLine();

                        Console.Write("Müəllifin adını daxil edin: ");
                        string author = Console.ReadLine();

                        Console.Write("Qiyməti daxil edin: ");
                        if (double.TryParse(Console.ReadLine(), out double price))
                        {
                            Book book = new Book(name, author, price);
                            library.AddBook(book);
                            Console.WriteLine(" Kitab uğurla əlavə olundu.");
                        }
                        else
                        {
                            Console.WriteLine(" Qiymət düzgün deyil.");
                        }
                        break;

                    case "2":
                        Console.Write("Axtarılan kitabın ID-sini daxil edin: ");
                        int id = Convert.ToInt32(Console.ReadLine);
                       
                            Book found = library.GetBookById(id);
                            if (found != null)
                                found.ShowInfo();
                            else
                                Console.WriteLine(" Kitab tapılmadı.");
                        
                        break;

                    case "3":
                        Console.Write("Silinəcək kitabın ID-sini daxil edin: ");
                        int removedId = Convert.ToInt32(Console.ReadLine());
                        bool removed = library.RemoveBook(removedId);
                        if (removed )
                        {
                            Console.WriteLine(" Kitab silindi (əgər ID doğru idisə).");
                        }
                        else
                        {
                            Console.WriteLine(" Belə bir ID-yə sahib kitab tapılmadı.");

                        }
                        break;

                    case "4":
                        Console.Write("Yenilənəcək kitabın ID-sini daxil edin: ");
                        if (int.TryParse(Console.ReadLine(), out int updateId))
                        {
                            Console.Write("Yeni kitab adı: ");
                            string newName = Console.ReadLine();

                            Console.Write("Yeni müəllif adı: ");
                            string newAuthor = Console.ReadLine();

                            Console.Write("Yeni qiymət: ");
                            if (double.TryParse(Console.ReadLine(), out double newPrice))
                            {
                                Book newBook = new Book(newName, newAuthor, newPrice);
                                library.Update(updateId, newBook);
                                Console.WriteLine(" Kitab yeniləndi (əgər ID mövcud idisə).");
                            }
                            else
                            {
                                Console.WriteLine(" Qiymət düzgün deyil.");
                            }
                        }
                        break;

                    case "5":
                        Console.WriteLine(" Bütün kitablar:");
                        library.GetAllBooks();
                        break;

                    case "0":
                        Console.WriteLine(" Proqramdan çıxılır...");
                        break;

                    default:
                        Console.WriteLine(" Yanlış seçim etdiniz.");
                        break;
                }

            } while (choice != "0");
        }
    }
}
    
