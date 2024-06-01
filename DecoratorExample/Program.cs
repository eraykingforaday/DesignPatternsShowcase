class Program
{
    static void Main(string[] args)
    {
        ConcreteComponent component = new ConcreteComponent();
        ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
        ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();

        decoratorA.SetComponent(component);
        decoratorB.SetComponent(decoratorA);

        decoratorB.Operation();
    }
}