using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Visitor.Visitors
{
    public class Necessity : Visitable
    {
        private double _price;
        public Necessity(double price)
        {
            _price = price;
        }
        public double GetPrice()
        {
            return _price;
        }
        public double Accept(Visitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
