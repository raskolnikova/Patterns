using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
   public class Espresso : Coffee
    {
        public Espresso() : base("Эспрессо")
        {

        }

        public override int GetCost()
        {
            return 100;
        }
    }
}
