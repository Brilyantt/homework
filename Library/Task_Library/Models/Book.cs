

namespace Task_Library.Models;

public class Book
{
    private static int _idCounter = 0;
    public int Id { get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public double Price     { get; set; }


    public Book(string name, string authorName, double price)
    {
        Id = _idCounter ++;
        Name = name;
        AuthorName = authorName;
        Price = price;
    }

    public string ShowInfo()
    {
        return $"Book Info: \nName: {Name}\nAuthor Name: {AuthorName}\nPrice: {Price} ";
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}
