namespace Abstraction;

public class Book : IBook
{
    public string Title { private get; set; }
    public int Page { get; set; }
    public string Author { get; set; }

    public string GetTitle()
        => this.Title;
    public void Read()
        => Console.WriteLine($"{this.Title} kitobi o'qildi!");
}
