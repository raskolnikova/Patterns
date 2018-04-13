using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public class Triangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Triangle");
        }

        public void Fill()
        {
            Console.WriteLine("Fill Triangle");
        }
    }
}
