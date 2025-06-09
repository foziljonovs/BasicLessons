namespace InterfaceAndAbstractClass;

public class BookServiceTwo : IBook, ILibrary
{
    public void GetAllBooks()
        => Console.WriteLine("Getting all books in BookServiceTwo...");

    public void Read()
        => Console.WriteLine("Reading the book in BookServiceTwo...");
    public void Write(string text)
        => Console.WriteLine($"Writing to the book in BookServiceTwo: {text}");
}
