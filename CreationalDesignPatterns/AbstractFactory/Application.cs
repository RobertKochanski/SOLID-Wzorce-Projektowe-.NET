namespace AbstractFactory
{
    internal class Application
    {
        private IUIElementFactory _factory;

        public Application(IUIElementFactory factory)
        {
            _factory = factory;
        }

        public void RenderUi()
        {
            var createNewFileButton = _factory.CreateButton();

            createNewFileButton.Render();

            var textbox = _factory.CreateTextBox();

            textbox.Render();
        }
    }
}
