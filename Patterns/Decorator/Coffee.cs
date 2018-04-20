using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public abstract class Coffee
    {
        protected Coffee(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
    }
}
