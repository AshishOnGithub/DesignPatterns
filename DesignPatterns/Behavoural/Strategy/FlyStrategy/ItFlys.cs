using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Strategy.FlyStrategy
{
    public class ItFlys : IFlys
    {
        public string Flys()
        {
            return "Flying high";
        }
    }
}
