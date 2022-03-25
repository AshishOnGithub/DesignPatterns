using DesignPatterns.Structural.Adapter.Legacy;
using DesignPatterns.Structural.Adapter.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    class TurkeyAdapter : Duck
    {
        Turkey _turkey;
        public TurkeyAdapter(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void fly()
        {
            for(int i = 0; i<5; i++)
                _turkey.Fly();
        }

        public void quack()
        {
            _turkey.Gobble();
        }
    }
}
