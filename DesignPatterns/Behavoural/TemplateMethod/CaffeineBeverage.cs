using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void prepareRecipe()
        {
            boilwater();
            brew();
            pourInCup();
            addCondiments();
        }

        public abstract void brew();
        public abstract void addCondiments();

        void boilwater()
        {
            Console.WriteLine("Boiling water");
        }
        void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }


    }
}
