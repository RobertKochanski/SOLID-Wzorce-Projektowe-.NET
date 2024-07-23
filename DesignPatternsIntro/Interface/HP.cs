namespace DesignPatternsIntro.Interface
{
    internal class HP : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("HP printing " + content);
        }
    }
}
