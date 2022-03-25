using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Pizza.NYStylePizza
{
    class NYStylePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("NYStyleCheezePizza is baked.");
        }

        public void Prepare()
        {
            Console.WriteLine("NYStyleCheezePizza is prepared.");
        }
    }
}
