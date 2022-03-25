using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.ChainOfResponsibility
{
    public class MultiplyNumber : IChain
    {
        IChain chain;

        public void SetNextChain(IChain nextChain)
        {
            this.chain = nextChain;
        }
        public void Calculate(Numbers request)
        {
            if (request.CalculationWanted == "Mul")
                Console.WriteLine("Number Multipled as " + (request.number1 * request.number2));
            else
                Console.WriteLine("Only works for Add, Sub, Mul only");
        }


    }
  
}
