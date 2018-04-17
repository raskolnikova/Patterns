using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public class LoggingListner:Listner
    {

        public LoggingListner():base()
        {
        }
        public override void Alert(string message)
        {
            Console.WriteLine("Logger: "+message);
        }
    }
}
