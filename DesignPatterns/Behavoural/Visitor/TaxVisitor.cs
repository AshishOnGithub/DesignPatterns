using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavoural.Visitor.Visitors;

namespace DesignPatterns.Behavoural.Visitor
{
    class TaxVisitor : Visitor
    {
        public double visit(Utensils liquor)
        {
            Console.WriteLine("Utensils item: Price with tax");
            return liquor.GetPrice() + liquor.GetPrice() * .18;
        }

        public double visit(Necessity necessity)
        {
            Console.WriteLine("Necessity item: Price with tax");
            return necessity.GetPrice() + necessity.GetPrice() * .14;
        }
    }
}
