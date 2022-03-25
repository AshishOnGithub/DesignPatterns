
using DesignPatterns.Creational.AbstractFactory.Pizza.NYStylePizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.PizzaStore
{
    class NYPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            IPizza pizza;
            if (type == "cheeze")
                pizza = new NYStylePizza();
            else
                pizza = new NYStyleVegiePizza();

            return pizza;

        }
    }
}
