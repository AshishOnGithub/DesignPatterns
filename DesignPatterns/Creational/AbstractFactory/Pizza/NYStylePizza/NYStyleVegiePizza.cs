using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Pizza.NYStylePizza
{
    class NYStyleVegiePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("NYStyleVegiePizza is baked.");
        }

        public void Prepare()
        {
            Console.WriteLine("NYStyleVegiePizza is prepared.");
        }
    }
}
