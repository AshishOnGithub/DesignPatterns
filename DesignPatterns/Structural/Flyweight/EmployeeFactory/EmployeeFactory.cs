using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.EmployeeFactory
{
    public class EmployeeFactory
    {
        private static Dictionary<string, IEmployee> employeeObjectMap = new Dictionary<string, IEmployee>();

        public static IEmployee GetEmployee(string type)
        {
            IEmployee employee = null;

            if (employeeObjectMap.ContainsKey(type))
                employee = employeeObjectMap[type];
            else
            {
                switch (type)
                {
                    case "Developer":
                        Console.WriteLine("Creating Developer instance");
                        employee = new Developer();
                        break;
                    case "Tester":
                        Console.WriteLine("Creating Tester instance");
                        employee = new Tester();
                        break;
                    default:
                        Console.WriteLine("No such employee found");
                        break;

                }

                employeeObjectMap.Add(type, employee);

            }

            return employee;
        }

    }
}
