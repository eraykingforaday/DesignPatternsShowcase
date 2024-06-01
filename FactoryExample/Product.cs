public abstract class Product
{
    public abstract void Operate();
}

public class ConcreteProductA : Product
{
    public override void Operate()
    {
        Console.WriteLine("Product A operation.");
    }
}

public class ConcreteProductB : Product
{
    public override void Operate()
    {
        Console.WriteLine("Product B operation.");
    }
}