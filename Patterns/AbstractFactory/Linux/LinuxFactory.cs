using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Linux
{
   public class LinuxFactory:IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new LinuxCheckBox();
        }
    }
}
