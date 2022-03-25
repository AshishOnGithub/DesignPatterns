using DesignPatterns.Behavoural.Strategy.FlyStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Strategy
{
    public class Animal
    {
        public string name { get; set; }
        public double height { get; set; }
        public int weight { get; set; }
        public IFlys flys;

        public void TryToFly()
        {
            Console.WriteLine(flys.Flys());
        }
    }

   
}
