using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class DatabaseExecuterProxy : IDatabaseExecutor
    {
        IDatabaseExecutor executor;
        bool isAdmin = false;
        public DatabaseExecuterProxy(string name, string password)
        {
            if (name == "Ashish" && password == "1234")
                isAdmin = true;
            executor = new DatabaseExecutor();
        }
        public void ExecuteDatabase(string query)
        {
            if (isAdmin)
                executor.ExecuteDatabase(query);
            else
                Console.WriteLine("You do not have permission to execute this command");
        }
    }
}
