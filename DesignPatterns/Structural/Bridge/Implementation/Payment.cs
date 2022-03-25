using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    
    public abstract class Payment
    {
        public IPaymentSystem _PaymentSystem;
        public abstract void MakePayment();
    }
}
