class Program
{
    static void Main(string[] args)
    {
        Singleton singleton = Singleton.Instance;
        singleton.DoSomething();
    }
}