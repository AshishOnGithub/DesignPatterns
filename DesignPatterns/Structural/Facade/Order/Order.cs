using DesignPatterns.Structural.Facade.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.Order
{
    public class Orders : IOrders
    {
        public bool MakeOrder(IList<Item> cart, int paymentId)
        {
            Console.WriteLine("Order placed");
            return true;
        }

        public bool LockItemsforCheckout(IList<Item> cart)
        {
            Console.WriteLine("Order Items locked");
            return true;
        }
    }
}
