using System.Threading.Channels;

namespace InterfaceAndAbstractClass;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public abstract void Speak();
    public virtual void Eat()
        => Console.WriteLine($"{Name} is eating.");
}

public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age)
    {
    }

    public override void Speak()
        => Console.WriteLine($"{Name} roars!");

    public override void Eat()
        => Console.WriteLine($"{this.Name} eating.");
}