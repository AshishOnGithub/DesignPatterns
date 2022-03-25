using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Pizza.ChicagoStyle
{
    class ChicagoStyleVegiePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("ChicagoStyleVegiePizza is baked.");
        }

        public void Prepare()
        {
            Console.WriteLine("ChicagoStyleVegiePizza is prepare.");
        }
    }
}
