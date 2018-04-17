using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
  public class EventManager
  {
      private List<Listner> _listners;

      public EventManager()
      {
          _listners = new List<Listner>();
      }

        public void Subscribe(EventTypes eventType, Listner listner)
        {
            listner.Subscriptions.Add(eventType);
            _listners.Add(listner);
            Console.WriteLine("Subscribed to "+ eventType);
        }

        public void Unsubscribe(EventTypes eventType, Listner listner)
        {
            listner.Subscriptions.Remove(eventType);
            _listners.Remove(listner);
            Console.WriteLine("Unsubscribed from " + eventType);
        }

        public void Notify(EventTypes eventTypeFilter, string message)
        {
            foreach (var listner in _listners.Where(x=>x.Subscriptions.Contains(eventTypeFilter)))
            {
                listner.Alert(message);
            }
        }
    }
}
