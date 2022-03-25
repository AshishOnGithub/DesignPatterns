using DesignPatterns.Structural.Facade.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Facade.Order;

namespace DesignPatterns.Structural.Facade
{
    class UserOrder : IUserOrder
    {
        Cart cart ;

        public UserOrder()
        {
            cart = new Cart();
        }

        public bool AddToCart(int itemId, int qty, int userId)
        {

            cart.AddToCart(itemId, qty, userId);
            return true;
        }

        public bool PlaceOrder(int userId, int paymentId)
        {
            IOrders order = new Orders();
            order.LockItemsforCheckout(cart.GetCart(userId));
            order.MakeOrder(cart.GetCart(userId), paymentId);
            return true;
        }
    }
}
