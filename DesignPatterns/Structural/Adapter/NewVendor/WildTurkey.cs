using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Vendor
{
    class WildTurkey: Turkey
    {
        public void Fly()
        {
            Console.WriteLine("Flying at short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
    }
}
