using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public class Rectangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }

        public void Fill()
        {
            Console.WriteLine("Fill Rectangle");
        }
    }
}
