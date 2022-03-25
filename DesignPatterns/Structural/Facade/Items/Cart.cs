using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.Items
{
    class Cart
    {
        public IList<Item> items;
        public Cart()
        {
            items = new List<Item>();
        }

        public bool AddToCart(int itemId, int qty, int userId)
        {
            items.Add(new Item { id = itemId, quantity = qty });
            Console.WriteLine("Item Added to cart");
            return true;
        }

        public IList<Item> GetCart(int userId)
        {
            Console.WriteLine("Item retrieved from cart");
            return items;
        }

    }
}
