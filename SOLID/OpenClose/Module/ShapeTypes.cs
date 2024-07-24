namespace OpenClose.Modules
{
    //public enum ShapeType
    //{
    //    Circle,
    //    Rectangle
    //}

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Shape
    {
        public virtual void Render()
        {

        }
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public override void Render()
        {
            Console.WriteLine("Render circle...");
        }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Heigth { get; set; }
        public Point TopLeft { get; set; }

        public override void Render()
        {
            Console.WriteLine("Render rectangle...");
        }
    }
}
