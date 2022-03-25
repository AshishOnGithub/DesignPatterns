using DesignPatterns.Structural.Adapter.Legacy;
using DesignPatterns.Structural.Adapter.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.LegacySystem
{
    class TurkeyUser
    {
        Duck _duck;

        public TurkeyUser(Duck duck)
        {
            _duck = duck;
        }

        public void UseTurkey()
        {
            _duck.fly();
            _duck.quack();
        }
    }
}
