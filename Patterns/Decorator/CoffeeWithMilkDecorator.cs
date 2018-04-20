using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public class CoffeeWithMilkDecorator:CoffeeDecorator
    {
        public CoffeeWithMilkDecorator(Coffee coffee):base(coffee.Name+ ",с молоком",coffee)
        {

        }
        public override int GetCost()
        {
            return Coffee.GetCost() + 10;
        }
    }
}
