namespace Amaliyot;

public class User
{
    private int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    private string Email { get; set; }
    private string Password { get; set; }
    public string PhoneNumber { get; set; }

    public User(int id, string fullName, int age, string email, string password, string phoneNumber)
    {
        this.Id = id;
        this.FullName = fullName;
        this.Age = age;
        this.Email = email;
        this.Password = password;
        this.PhoneNumber = phoneNumber;
    }

    public int getId()
        => this.Id;

    public string getEmail()
        => this.Email;

    public string getPassword()
        => this.Password;
}
