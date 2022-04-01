using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    class Tester : IEmployee
    {
        string _job;
        string _skill;
      
        public void assignJob(string job)
        {
            _job = job;
        }

        public void assignSkill(string skill)
        {
            _skill = skill;
        }

        public void task()
        {
            Console.WriteLine("Tester with {0} skill have {1} job", _skill, _job);
        }
    }
}
