using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Legacy
{
    class CityDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("Fly");
        }

        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
