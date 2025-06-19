using System.Threading.Channels;

namespace Enumeration;

public class Product
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
    public DateTime CreatedDate { get; set; }
    public Made Made { get; set; }

    public Product()
    {
        this.Name = "Qora kofe";
        this.Brand = "Nescafe";
        this.Price = 10000;
        this.CreatedDate = DateTime.Now;
        this.Made = (Made)1;
    }

    public void GetProduct()
        => Console.WriteLine($"name: {Name}, brand: {Brand}, price: {Price}, made: {Made}");
}
