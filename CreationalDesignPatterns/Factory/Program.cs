﻿namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();

            var circle = shapeFactory.CreateShape(ShapeType.Circle);

            circle.Render();

            var rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);

            rectangle.Render();

            var triangle = shapeFactory.CreateShape(ShapeType.Triangle);

            triangle.Render();
        }
    }
}
