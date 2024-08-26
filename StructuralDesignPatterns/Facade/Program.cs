namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scanFacade = new ScanFacade();

            scanFacade.Scan("http://github.com/somerepo");
        }
    }
}
