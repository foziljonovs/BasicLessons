namespace InterfaceAndAbstractClass;

public class BookService : IBook
{
    public void Read()
        => Console.WriteLine("Reading the book...");

    public void Write(string text)
        => Console.WriteLine($"Writing to the book: {text}");
}
