using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.ChainOfResponsibility
{
    public class SubtractNumbers : IChain
    {
        IChain chain;


        public void SetNextChain(IChain nextChain)
        {
            this.chain = nextChain;
        }
        public void Calculate(Numbers request)
        {
            if (request.CalculationWanted == "Sub")
                Console.WriteLine("Number Subtracted as " + (request.number1 - request.number2));
            else
                chain.Calculate(request);
        }


    }
   
}
