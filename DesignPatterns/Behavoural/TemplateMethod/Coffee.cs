using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.TemplateMethod
{
    class Coffee : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        public override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}
