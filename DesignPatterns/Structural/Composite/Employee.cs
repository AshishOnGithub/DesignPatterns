using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    class Employee : IEmployee
    {
        private string _name;
        private string _department;
        public Employee(string name, string department)
        {
            _name = name;
            _department = department;
        }

        public void Getdetails()
        {
            Console.WriteLine("Employee Name: " + _name+", Dept: "+_department); 
        }
    }
}
