using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
   public class Form
   {
       public EventManager EventManager { get; set; }

       public Form()
       {
           EventManager=new EventManager();
       }

       public void Click()
       {
           EventManager.Notify(EventTypes.Click,"click ( X: 255, Y:458 )");
       }

       public void FocusInput()
       {
           EventManager.Notify(EventTypes.Focus, "focus on input");
       }

       public void KeyUp()
       {
           EventManager.Notify(EventTypes.KeyUp, "key up: key code 13");
       }

       public void Hover()
       {
           EventManager.Notify(EventTypes.Hover, "Hover component");
       }
    }
}
