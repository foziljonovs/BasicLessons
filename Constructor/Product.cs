namespace Constructor;

public class Product
{
    //default constructorda parametr bolmaydi
    public Product()
    {
        this.Name = "example";
        this.Description = "example";
        this.Price = 0.0;
    }

    public Product(string name, double price)
    {
        this.Name = name;
        this.Description = "example";
        this.Price = price;
    }

    public Product(string name, string description)
    {
        this.Name = name;
        this.Description = description;
        this.Price = 0.0;
    }

    public Product(string name, string description, double price)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
    }

    private string Name { get; set; }
    private string Description { get; set; }
    private double Price { get; set; }

    public string GetName() => Name;
    public string GetDescription() => Description;
    public double GetPrice() => Price;
}


public class Category
{
    public string Name { get; set; }
    public string Description { get; set; }
}