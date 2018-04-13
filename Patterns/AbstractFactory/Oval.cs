using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public class Oval:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Oval");
        }

        public void Fill()
        {
            Console.WriteLine("Fill Oval");
        }
    }
}
