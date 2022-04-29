using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.ChainOfResponsibility
{
    public class Authentication : IChain
    {
        IChain chain;

        public void SetNextChain(IChain nextChain)
        {
            this.chain = nextChain;
        }
        public void ProcessNext(Request request)
        {
            if (request.userId == 1 && request.password == "1234")
            {
                Console.WriteLine("Authentication successfull");
                chain.ProcessNext(request);
            }
            else
            {
                Console.WriteLine("Authentication unsuccessfull, request dropped");
            }
                
        }
        
    }
}
