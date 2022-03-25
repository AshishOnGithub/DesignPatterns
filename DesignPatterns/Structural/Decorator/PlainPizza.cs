using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    class PlainPizza : Pizza
    {
        public double GetCost()
        {
            return 4.0;
        }

        public string GetDescription()
        {
            return "Plain Pizza";
        }
    }
}
