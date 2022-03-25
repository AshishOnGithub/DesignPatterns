using DesignPatterns.Creational.AbstractFactory.Pizza.ChicagoStyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.PizzaStore
{
    class ChicagoPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            IPizza pizza;
            if (type == "cheeze")
                pizza = new ChicagoStyleCheezePizza();
            else
                pizza = new ChicagoStyleVegiePizza();

            return pizza;

        }
    }
}
