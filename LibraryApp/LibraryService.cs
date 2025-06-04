namespace LibraryApp;

public static class LibraryService
{
    private static List<Book> books = new List<Book>();

    public static void AddBook(Book book)
        => books.Add(book);

    public static List<Book> GetBooks()
        => books;

    public static bool BorrowBook(string title)
    {
        var book = books.FirstOrDefault(b => b.GetTitle() == title &&
            b.GetAvailability() == true);

        if (book is null)
            return false;

        book.SetAvailability(false);
        return true;
    }

    public static bool ReturnBook(string title)
    {
        var book = books.FirstOrDefault(b => b.GetTitle() == title &&
            b.GetAvailability() == false);

        if (book is null)
            return false;

        book.SetAvailability(true);
        return true;
    }
}
