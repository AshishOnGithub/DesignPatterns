using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public interface IEmployee
    {
        public void assignSkill(string skill);
        public void assignJob(string jobs);
        public void task();
    }
}
