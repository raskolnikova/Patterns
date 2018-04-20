using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public abstract class CoffeeDecorator:Coffee
    {
        protected Coffee Coffee;

        protected CoffeeDecorator(string name,Coffee coffee):base(name)
        {
            Coffee = coffee;
        }
      
    }
}
