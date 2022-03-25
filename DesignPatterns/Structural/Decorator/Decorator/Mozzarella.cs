using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(Pizza pizza) : base(pizza)
        {

        }

        public override double GetCost()
        {
            return  _pizza.GetCost() + .50;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() +", Mozzarella";
        }
    }
}
