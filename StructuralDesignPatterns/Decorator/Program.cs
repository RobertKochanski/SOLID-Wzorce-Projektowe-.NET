namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaBase = new MediumPizza();

            var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);

            Console.WriteLine($"mediumPizzaWithCheese: {mediumPizzaWithCheese.CalculatePrice()}");

            var p2 = new SalamiPizzaDecorator(mediumPizzaWithCheese);

            Console.WriteLine($"mediumPizzaWithCheeseAndSalami: {p2.CalculatePrice()}");
        }
    }
}
