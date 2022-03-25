using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Pizza
{
    public class NYStylePizza : IMyPizza
    {
      
        public void Prepare()
        {
            Console.WriteLine("NYStyleCheezePizza is prepared.");
        }
    }
}
