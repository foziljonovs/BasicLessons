namespace Incapsulation;

public class Person
{
    private string FullName { get; set; }
    private int Age { get; set; }
    private string PhoneNumber { get; set; }
    private string Address { get; set; }
    //public Person()
    //{
    //    this.FullName = "Abdulvosid Foziljonov";
    //    this.Age = 20;
    //    this.PhoneNumber = "998945666964";
    //    this.Address = "Fergana, Uzbekistan";  
    //}

    //public Person(string fullName, int age, string phoneNumber, string address)
    //{
    //    this.FullName = fullName;
    //    this.Age = age;
    //    this.PhoneNumber = phoneNumber;
    //    this.Address = address;
    //}

    public void SetFullName(string fullName)
        => this.FullName = fullName;

    public void SetAge(int age)
        => this.Age = age;

    public void SetPhoneNumber(string phoneNumber)
        => this.PhoneNumber = phoneNumber;

    public void SetAddress(string address)
        => this.Address = address;

    public string GetFullName()
        => this.FullName;

    public int GetAge()
        => this.Age;

    public string GetPhoneNumber()
        => this.PhoneNumber;

    public string GetAddress()
        => this.Address;

    public void PrintInfo()
        => Console.WriteLine($"full name: {FullName}\t" +
                            $"age: {Age}\t" +
                            $"phone-number: {PhoneNumber}\t" +
                            $"address: {Address}");
}
