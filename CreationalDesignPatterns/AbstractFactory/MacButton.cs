using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MacButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Render mac button");
        }

        public void Render()
        {
            Console.WriteLine("Handle mac click enevt");
        }
    }
}
