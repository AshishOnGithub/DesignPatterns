using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.PizzaStore
{
    abstract class PizzaStore
    {
        public abstract IPizza CreatePizza(string type);
        public void OrderPizza(string type)
        {
            IPizza pizza = CreatePizza(type);
            pizza.Bake();
            pizza.Prepare();
            Console.WriteLine("Pizza ordered successfully");
        }
    }
}
