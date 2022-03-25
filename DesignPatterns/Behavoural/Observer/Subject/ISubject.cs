using DesignPatterns.Behavoural.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Observer.Subject
{
    public interface ISubject
    {
        public void register(IObserver o);
        public void unRegister(IObserver o);
        public void notifyObservers();

    }
}
