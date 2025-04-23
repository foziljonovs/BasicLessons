public class Mathematics
{
    public int add(int a, int b) => a + b;
    public int subtract(int a, int b) => a - b;
    public int multiply(int a, int b) => a * b;
    public int divide(int a, int b) => a / b;
}

class Program
{
    public static void Main()
    {
        //Mathematics sinfidan yangi object yaratildi
        Mathematics math = new Mathematics();

        int a, b;
        char belgi;

        while (true)
        {
            Console.Write("+\t-\t*\t/\t-lardan bittasini tanlang: ");
            belgi = Convert.ToChar(Console.ReadLine());

            Console.Write("1-sonni kiriting: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2-sonni kiriting: ");
            b = Convert.ToInt32(Console.ReadLine());

            int res = belgi switch
            {
                '+' => math.add(a, b),
                '-' => math.subtract(a, b),
                '*' => math.multiply(a, b),
                '/' => math.divide(a, b),
                _ => throw new InvalidOperationException("Noto'g'ri amal tanlandi")
            };

            Console.WriteLine($"Natija: {res}");
        }
    }
}