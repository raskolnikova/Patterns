using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
   public class Application
   {
       private IGUIFactory _factory;

       public Application(IGUIFactory factory)
       {
           _factory = factory;
       }

       public void Draw()
       {
           _factory.CreateButton().Draw();
           _factory.CreateCheckBox().Draw();
       }
    }
}
