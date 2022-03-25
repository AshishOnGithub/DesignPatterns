using DesignPatterns.Behavoural.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Observer.Subject
{
    class DeliveryData : ISubject
    {
        IList<IObserver> observers;
        private string location;
        public DeliveryData()
        {
            observers = new List<IObserver>();
        }

        public void register(IObserver o)
        {
            observers.Add(o);
        }

        public void unRegister(IObserver o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.update(location);
        }

        public void SetLocation(string location)
        {
            this.location = location;
        }
    }
}
