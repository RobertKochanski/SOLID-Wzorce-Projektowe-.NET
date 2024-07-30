namespace Liskov.Shapes
{
    internal class Square : Rectangle
    {
        public override void SetHeight(int height)
        {
            _width = height;
            _height = height;
        }

        public override void SetWidth(int width) 
        { 
            _width = width; 
            _height = width;
        }
    }
}
