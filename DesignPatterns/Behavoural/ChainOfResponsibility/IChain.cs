using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.ChainOfResponsibility
{
    public interface IChain
    {
        public void SetNextChain(IChain nextChain);
        public void Calculate(Numbers request);
    }

}
