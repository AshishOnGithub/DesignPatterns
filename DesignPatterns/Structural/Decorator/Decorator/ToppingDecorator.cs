using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class ToppingDecorator : Pizza
    {
        protected Pizza _pizza;
        public ToppingDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }
        public abstract double GetCost();

        public abstract string GetDescription();
    }
}
