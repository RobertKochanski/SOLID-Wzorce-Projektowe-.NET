namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cfg = Configuration.GetInstance();
            var cfg2 = Configuration.GetInstance();

            if (ReferenceEquals(cfg, cfg2))
            {
                Console.WriteLine("Configuration is a singleton");
            }
        }
    }
}
