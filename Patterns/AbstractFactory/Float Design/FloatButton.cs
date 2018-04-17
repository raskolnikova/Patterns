using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public class FloatButton:IButton
    {
        public void Draw()
        {
            Console.WriteLine("Float button");
        }
    }
}
