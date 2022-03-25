using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Pizza
{
    public class ChicagoStylePizza : IMyPizza
    {
        

        public void Prepare()
        {
            Console.WriteLine("ChicagoStyleCheezePizza is prepared.");
        }
    }
}
