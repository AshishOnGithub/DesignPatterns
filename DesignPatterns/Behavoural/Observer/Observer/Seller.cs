using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Observer.Observer
{
    class Seller : IObserver
    {
        public void update(string location)
        {
            ShowLocation(location);
        }

        public void ShowLocation (string location)
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<Current location from Seller is >>>>>>>>>>>>>>>> " + location);
        }
    }
}
