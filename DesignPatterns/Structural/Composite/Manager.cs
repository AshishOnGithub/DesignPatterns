using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Manager : IEmployee
    {
        private string _name;
        private string _department;
        private List<IEmployee> _employees;
        public Manager(string name, string department, List<IEmployee> employees)
        {
            _name = name;
            _department = department;
            _employees = employees;
        }

        public void Getdetails()
        {
            Console.WriteLine("Manager Name: " + _name + ", Dept: " + _department);
            foreach (Employee employee in _employees)
                employee.Getdetails();
        }
    }
}
