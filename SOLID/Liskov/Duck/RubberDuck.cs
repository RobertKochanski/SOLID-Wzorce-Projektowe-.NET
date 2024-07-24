namespace Liskov.Duck
{
    internal class RubberDuck : Duck
    {
        public override void Fly()
        {
            // cant implement this properly
            // Liskov Substitution Principle failed
        }

        public override void Quack()
        {
            Console.WriteLine("Rubber duck quack");
        }

        public override void Swim()
        {
            Console.WriteLine("Rubber duck swim");
        }
    }
}
