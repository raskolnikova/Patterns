using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }

        public void Fill()
        {
            Console.WriteLine("Fill Circle");
        }
    }
}
