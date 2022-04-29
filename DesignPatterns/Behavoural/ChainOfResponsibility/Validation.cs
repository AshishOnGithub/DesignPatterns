using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.ChainOfResponsibility
{
    public class Validation : IChain
    {
        IChain chain;

        public void SetNextChain(IChain nextChain)
        {
            this.chain = nextChain;
        }
        public void ProcessNext(Request request)
        {
            if (request.orderData == "{item1, item2}")
            {
                Console.WriteLine("Validation successfull");
                //chain.Calculate(request);
            }
            else
                Console.WriteLine("Validation unsuccessfull, request dropped");
        }


    }
  
}
