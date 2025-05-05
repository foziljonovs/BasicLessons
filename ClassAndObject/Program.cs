using System.Threading.Channels;

class Car
{
    public string Brand { get; private set; }
    public string Name { get; private set; }
    public int Year { get; private set; }
    public string Color { get; private set; }

    //default constructor
    public Car()
    {
        this.Brand = "Toyota";
        this.Name = "Corolla";
        this.Year = 2020;
        this.Color = "Red";
    }

    public Car(string brand, string name, int year, string color) 
    {
        this.Brand = brand;
        this.Name = name;
        this.Year = year;
        this.Color = color;
    }

    public Car(string brand, string name)
    {
        this.Brand = brand;
        this.Name = name;
        this.Year = 2020;
        this.Color = "Red";
    }

    public void printInfo()
        => Console.WriteLine($"Brand: {this.Brand}, Name: {this.Name}, Year: {this.Year}, Color: {this.Color}");
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.printInfo();

        Car car2 = new Car("Honda", "Civic", 2021, "Blue");
        car2.printInfo();

        Car car3 = new Car("Ford", "Mustang");
        car3.printInfo();
    }
}