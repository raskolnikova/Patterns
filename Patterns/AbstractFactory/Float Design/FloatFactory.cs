using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Windows
{
   public class FloatFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new FloatButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new FloatCheckBox();
        }
    }
}
