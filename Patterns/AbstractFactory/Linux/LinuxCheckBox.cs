using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public class LinuxCheckBox:ICheckBox
    {
        public void Draw()
        {
            Console.WriteLine("Linux CheckBox");
        }
    }
}
