namespace AbstractFactory
{
    internal class MacButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Render mac button");
        }

        public void Render()
        {
            Console.WriteLine("Handle mac click enevt");
        }
    }
}
