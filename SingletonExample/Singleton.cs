public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();

    private Singleton()
    {
    }

    public static Singleton Instance
    {
        get
        {
            return instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton instance is working.");
    }
}