namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strategy = new CarStrategy();

            var map = new Map(strategy);

            Coordinate start = new Coordinate();
            Coordinate end = new Coordinate();

            map.CreateRoute(start, end);
        }
    }
}
