using DesignPatterns.Structural.Facade.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    interface IUserOrder
    {
        public bool AddToCart(int itemId, int qty, int userId);
        public bool PlaceOrder(int userId, int paymentId);
    }
}
