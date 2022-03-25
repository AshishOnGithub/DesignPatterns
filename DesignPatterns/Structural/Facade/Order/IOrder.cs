using DesignPatterns.Structural.Facade.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.Order
{
    public interface IOrders
    {
        public bool MakeOrder(IList<Item> cart, int paymentId);
        public bool LockItemsforCheckout(IList<Item> cart);
    }
}
