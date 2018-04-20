using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public class CoffeeWithChocolateSyrupDecorator:CoffeeDecorator
    {
        public CoffeeWithChocolateSyrupDecorator(Coffee coffee):base(coffee.Name+ ",с шоколадным сиропом",coffee)
        {

        }
        public override int GetCost()
        {
            return Coffee.GetCost() + 20;
        }
    }
}
