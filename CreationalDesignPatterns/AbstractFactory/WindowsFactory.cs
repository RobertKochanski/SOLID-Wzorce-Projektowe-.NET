namespace AbstractFactory
{
    internal class WindowsFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextbox CreateTextBox()
        {
            return new WindowsTextbox();
        }
    }
}
