using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class DatabaseExecutor : IDatabaseExecutor
    {
        public void ExecuteDatabase(string query)
        {
            Console.WriteLine("Query Executed " + query);
        }
    }
}
