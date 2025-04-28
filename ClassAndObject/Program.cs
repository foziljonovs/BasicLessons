//modifikator - (public, private, internal, protected)

public class User
{
    //user properties
    public string FullName { get; set; }
    public string Email { private get; set; }
    private string Password { get; set; }

    public string getEmail()
        => Email;

    public void setPassword(string password)
        => Password = password;

    public string getPassword()
        => Password;
}

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        user.FullName = "foziljonovs";
        user.Email = "abdulvosidfoziljonov2@gmail.com";
        user.setPassword("1234");
        Console.WriteLine($"username - {user.FullName}, email - {user.getEmail()}, password - {user.getPassword()}");
    }
}