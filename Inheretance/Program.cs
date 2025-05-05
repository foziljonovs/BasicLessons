
public class Shape
{
    public double X { get; set; }
    public double Y { get; set; }

    public Shape()
    {
        this.X = 5;
        this.Y = 5;
    }

    public Shape(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Draw()
    {
        Console.WriteLine($"{X} va {Y} - orqali shakl chizildi.");
    }
}

public class Circle : Shape
{
    public Circle()
    {
        this.X = 10;
        this.Y = 10;
    }
    public Circle(double x, double y) : base(x, y)
    {

    }
}

public static class Program
{
    public static void Main(string[] args)
    {
        Shape shape = new Shape();
        shape.Draw();

        Circle circle = new Circle();
        circle.Draw();

        Circle circle2 = new Circle(20, 30);
        circle2.Draw();

        Shape circle3 = new Circle(20, 30);
        circle3.Draw();
    }
}