namespace Mediator
{
    internal class Checkbox : Component
    {
        public void Select()
        {
            Console.WriteLine("Checkbox selected");

            this._mediator.Notify(this, "checkbox selected");
        }

        public void SaveValue()
        {
            Console.WriteLine("Checkbox value saved");
        }
    }
}
