using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class IDBIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string PaymentSystem)
        {
            Console.WriteLine("Using IDBI Bank gateway for " + PaymentSystem);
        }
    }
}
