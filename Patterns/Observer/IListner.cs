using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
  public abstract class Listner
  {
      
     public List<EventTypes> Subscriptions { get; set; }

      protected Listner()
      {
          Subscriptions = new List<EventTypes>();
      }

        public abstract void Alert(string message);
  }
}
