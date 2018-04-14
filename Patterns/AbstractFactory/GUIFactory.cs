using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public interface IGUIFactory
   {
       IButton CreateButton();
       ICheckBox CreateCheckBox();
   }
}
