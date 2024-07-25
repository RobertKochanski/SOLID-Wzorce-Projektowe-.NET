namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Circle();
            c1.Radius = 5;
            c1.X = 1;
            c1.Y = 2;
            c1.Border = new Border()
            {
                color = "Blue",
                size = "2px"
            };

            var c2 = (Circle)c1.Clone();

            bool referenceEquals = ReferenceEquals(c1, c2);
            Console.WriteLine(referenceEquals);

            bool borderReferenceEquals = ReferenceEquals(c1.Border, c2.Border);
            Console.WriteLine(borderReferenceEquals);
        }
    }
}
