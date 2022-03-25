using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class CardPayment : Payment
    {
        public override void MakePayment()
        {
            _PaymentSystem.ProcessPayment("Card Payment");
        }
    }
}
