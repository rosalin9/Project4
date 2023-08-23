using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public class InventorySystem
    {
        public string ProductName;
        public int Quantity;
        public double Price;

        public InventorySystem(string productName, int quantity, double price)
        {
            this.ProductName = productName;
            this.Quantity = quantity;
            this.Price = price;
        }
    }
}
