namespace AbstractFactory
{
    internal interface IUIElementFactory
    {
        IButton CreateButton();
        ITextbox CreateTextBox();
    }
}
