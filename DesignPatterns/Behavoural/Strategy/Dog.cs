using DesignPatterns.Behavoural.Strategy.FlyStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Strategy
{
    class Dog: Animal
    {
        public Dog()
        {
            flys = new CantFly();
        }
        public void DigHole()
        {
            Console.WriteLine("Dog digging hole");
        }
    }
}
