using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public class Trapeze:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Trapeze");
        }

        public void Fill()
        {
            Console.WriteLine("Fill Trapeze");
        }
    }
}
