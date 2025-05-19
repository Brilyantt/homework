
namespace Task_Library.Models;

public class Library
{
    public string Name { get; set; }
    public Book[] books;
    public int count;

    public Library()
    {
        books = new Book[15];
        count = 0;
    }

    public void AddBook(Book book)
    {
        if (count == books.Length)
        {
            Array.Resize(ref books, books.Length * 2);
        }

        books[count++] = book;
    }

    public Book GetBookById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i].Id == id)

                return books[i];
        }
        return null;
    }

    public bool RemoveBook(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i] != null && books[i].Id == id)
            {
                for (int j = i; j < count - 1; j++)
                {
                    books[j] = books[j + 1];
                }

                books[count - 1] = null; 
                count--; 
                return true; 
            }
        }
        return false; 
    }


    public Book[] GetBook(string name)
    {
        int matchCount = 0;

        for (int i = 0; i < count; i++)
        {
            if (books[i].Name == name)
                matchCount++;
        }

        Book[] matchedBooks = new Book[matchCount];
        int index = 0;

        for (int i = 0; i < count; i++)
        {
            if (books[i].Name == name)
            {
                matchedBooks[index++] = books[i];
            }
        }

        return matchedBooks;
    }

    public void GetAllBooks()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(books[i]);
        }
    }

    public void Update(int id, Book newBookData)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i].Id == id)
            {
                books[i].Name = newBookData.Name;
                return;
            }
        }
    }


}
