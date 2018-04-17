using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Linux
{
   public class MaterialFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MaterialButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MaterialCheckBox();
        }
    }
}
