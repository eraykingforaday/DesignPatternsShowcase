class Program
{
    static void Main(string[] args)
    {
        Product productA = ProductFactory.CreateProduct("A");
        productA.Operate();

        Product productB = ProductFactory.CreateProduct("B");
        productB.Operate();
    }
}