namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uiApplication = new Application(new MacFactory());

            uiApplication.RenderUi();
        }
    }
}
