namespace InterfaceAndAbstractClass;

public class BookServiceTwo : IBook
{
    public void Read()
        => Console.WriteLine("Reading the book in BookServiceTwo...");
    public void Write(string text)
        => Console.WriteLine($"Writing to the book in BookServiceTwo: {text}");
}
