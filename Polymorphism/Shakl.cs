namespace Polymorphism;

public class Shakl
{
    public virtual void Chizish()
        => Console.WriteLine("Shakl chizildi.");
}

public class Uchburchak : Shakl
{
    public override void Chizish()
        => Console.WriteLine("Uchburchak chizildi.");
}
