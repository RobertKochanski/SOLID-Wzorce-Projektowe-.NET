namespace Prototype
{
    public class Triangle : Shape
    {
        public override Shape Clone()
        {
            Triangle cloneBase = (Triangle)this.MemberwiseClone();

            cloneBase.Border = new Border()
            {
                size = Border.size,
                color = Border.color,
            };

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }
    }
}
