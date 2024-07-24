namespace OpenClose.Modules
{
    internal class Application
    {
        public void Render(List<Shape> shapes)
        {
            for (int i = 0; i < shapes.Count; i++)
            {

                shapes[i].Render();

                //ShapeType shapeType = shapes[i].ShapeType;
                //switch (shapeType)
                //{
                //    case ShapeType.Circle:
                //        RenderCircle((Circle)shapes[i]);
                //        break;
                //    case ShapeType.Rectangle:
                //        RenderRectangle((Rectangle)shapes[i]);
                //        break;
                //    default:
                //        break;
                //}
            }
        }

        //public void RenderCircle(Circle circle) 
        //{
        //    Console.WriteLine("Render circle...");
        //}

        //public void RenderRectangle(Rectangle rectangle)
        //{
        //    Console.WriteLine("Render rectangle...");
        //}
    }
}
