using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.ChainOfResponsibility
{
    public class Authorization : IChain
    {
        IChain chain;


        public void SetNextChain(IChain nextChain)
        {
            this.chain = nextChain;
        }
        public void ProcessNext(Request request)
        {
            if (request.role == "user")
            {
                Console.WriteLine("Authorization successfull");
                chain.ProcessNext(request);
            }
            else
                Console.WriteLine("Authorization unsuccessfull, request dropped");
        }

    }
   
}
