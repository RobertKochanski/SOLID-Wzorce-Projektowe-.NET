namespace Liskov.Duck
{
    internal class MountainDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Mountain duck flies");
        }

        public override void Quack()
        {
            Console.WriteLine("Mountain duck quack");
        }

        public override void Swim()
        {
            Console.WriteLine("Mountain duck swim");
        }
    }
}
