using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Observer.Observer
{
    public interface IObserver
    {
        public void update(string location);
    }
}
