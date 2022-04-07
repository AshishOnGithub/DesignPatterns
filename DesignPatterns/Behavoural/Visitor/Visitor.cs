using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavoural.Visitor.Visitors;

namespace DesignPatterns.Behavoural.Visitor
{
    public interface Visitor
    {
        public double visit(Utensils liquor);
        public double visit(Necessity necessity);

    }
}
