using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.ChainOfResponsibility
{
    public class Numbers
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public string CalculationWanted { get; set; }

        public Numbers(int newNumber1, int newNumber2, string calcWanted)
        {
            number1 = newNumber1;
            number2 = newNumber2;
            CalculationWanted = calcWanted;
        }

    }
}
