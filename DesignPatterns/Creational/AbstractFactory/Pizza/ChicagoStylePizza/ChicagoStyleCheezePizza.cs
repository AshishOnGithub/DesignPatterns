using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Pizza.ChicagoStyle
{
    class ChicagoStyleCheezePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("ChicagoStyleCheezePizza is baked.");
        }

        public void Prepare()
        {
            Console.WriteLine("ChicagoStyleCheezePizza is prepared.");
        }
    }
}
