using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class CityPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string PaymentSystem)
        {
            Console.WriteLine("Using Citi Bank gateway for " + PaymentSystem);
        }
    }
}
