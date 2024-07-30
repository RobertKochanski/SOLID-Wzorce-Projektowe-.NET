namespace AbstractFactory
{
    internal class MacFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextbox CreateTextBox()
        {
            return new MacTextbox();
        }
    }
}
