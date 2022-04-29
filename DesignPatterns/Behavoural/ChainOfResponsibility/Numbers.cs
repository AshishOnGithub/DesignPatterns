using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.ChainOfResponsibility
{
    public class Request
    {
        public int userId { get; set; }
        public string password{ get; set; }
        public string role { get; set; }
        public string orderData { get; set; }

        public Request(int userId, string password, string orderData, string role)
        {
            this.userId = userId;
            this.password = password;
            this.orderData = orderData;
            this.role = role;
        }

    }
}
