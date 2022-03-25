using DesignPatterns.Behavoural.Strategy.FlyStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Strategy
{
    class Bird: Animal
    {
        public Bird()
        {
            flys = new ItFlys();
        }
        public void Tweet()
        {
            Console.WriteLine("Bird twittering");
        }

    }
}
