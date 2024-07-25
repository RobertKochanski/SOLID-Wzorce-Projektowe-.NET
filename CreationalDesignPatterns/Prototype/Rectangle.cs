using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public override Shape Clone()
        {
            Rectangle cloneBase = (Rectangle)this.MemberwiseClone();

            cloneBase.Border = new Border()
            {
                size = Border.size,
                color = Border.color,
            };

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Render rectangle");
        }
    }
}
