using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public class CoffeeWithSugarDecorator:CoffeeDecorator
    {
        public CoffeeWithSugarDecorator(Coffee coffee):base(coffee.Name+ ",с сахором",coffee)
        {

        }
        public override int GetCost()
        {
            return Coffee.GetCost() + 5;
        }
    }
}
