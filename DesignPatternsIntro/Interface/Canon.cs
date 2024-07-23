namespace DesignPatternsIntro.Interface
{
    internal class Canon : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("Canon printing " + content);
        }
    }
}
