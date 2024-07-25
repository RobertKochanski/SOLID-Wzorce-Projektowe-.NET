using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            Circle cloneBase = (Circle)this.MemberwiseClone(); // Shallow clone (Border references stay same)

            cloneBase.Border = new Border() // Deep clone (Create new Border instance)
            {
                size = Border.size,
                color = Border.color,
            };

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Render circle");
        }
    }
}
