using DesignPatterns.Creational.Factory.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class PizzaFactory
    {
        public IMyPizza CreatePizza(string type)
        {
            IMyPizza pizza;
            if (type == "ny")
                pizza = new NYStylePizza();
            else
                pizza = new ChicagoStylePizza();


            return pizza;
        }

    }
}
