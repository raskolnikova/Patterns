using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public class LinuxButton:IButton
    {
        public void Draw()
        {
            Console.WriteLine("Linux button");
        }
    }
}
