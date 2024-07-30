namespace AbstractFactory
{
    internal class WindowsButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Render windows button");
        }

        public void Render()
        {
            Console.WriteLine("Handle windows click enevt");
        }
    }
}
