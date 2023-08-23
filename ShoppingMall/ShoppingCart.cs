using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class ShoppingCart
    {
        public string Product;
        public int Quantity;

        public ShoppingCart(string product,int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

    }
}
