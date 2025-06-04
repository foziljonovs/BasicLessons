namespace LibraryApp;

public class Book
{
    private string Title { get; set; }
    private string Author { get; set; }
    private int Year { get; set; }
    private bool IsAvailable { get; set; } = true;

    public Book(string title, string author, int year, bool isAvailable)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
        this.IsAvailable = isAvailable;
    }

    public void SetAvailability(bool isAvailable)
        => this.IsAvailable = isAvailable;

    public string GetTitle()
        => this.Title;

    public string GetAuthor()
        => this.Author;

    public int GetYear()
        => this.Year;

    public bool GetAvailability()
        => this.IsAvailable;
}
