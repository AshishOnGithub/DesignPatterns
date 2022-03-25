﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public interface IPaymentSystem
    {
        void ProcessPayment(string PaymentSystem);
    }
}
