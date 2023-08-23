using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public class Program
    {
        static List<InventorySystem> Items =new List<InventorySystem>();

        
        static void UpdateQuantity()
        {
            Console.Write("Enter Product name: ");
            string productname = Console.ReadLine();
            Console.Write("Enter quantity of {0}: ", productname);
            int quantity = Convert.ToInt32(Console.ReadLine());
            InventorySystem update = Items.Find(x => x.ProductName == productname);
            update.Quantity += quantity;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        }
        static void AddProduct()
        {
            Console.Write("Enter the product name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter the quantity of {0}: ", productName);
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of {0}: ", productName);
            double price = Convert.ToDouble(Console.ReadLine());
            Items.Add(new InventorySystem(productName, quantity, price)); 
        }

        static void DisplayProduct()
        {
            Console.WriteLine("Product Name         Quantity        Price");
            Console.WriteLine("-------------------------------------------");
            if (Items.Count > 0)
            {
                foreach (InventorySystem item in Items)
                {
                    Console.Write("{0,-20}", item.ProductName);
                    Console.Write("{0,-15}", item.Quantity);
                    Console.WriteLine(item.Price);
                }

            }
        }

        static void FindProduct(string pname)
        {
            InventorySystem res = Items.Find(x => x.ProductName == pname);
            Console.Write("{0,-20}",res.ProductName);
            Console.Write("{0,-15}", res.Quantity);
            Console.WriteLine(res.Price);

        } 
        static void FindProduct(double price)
        {
            InventorySystem res = Items.Find(x => x.Price == price);
            Console.Write("{0,-20}", res.ProductName);
            Console.Write("{0,-15}", res.Quantity);
            Console.WriteLine(res.Price);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Retail Store!");
            Console.WriteLine();
            Console.WriteLine("1. Add product to the Inventory");
            Console.WriteLine("2. Update quantity of a product");
            Console.WriteLine("3. Search the product by name");
            Console.WriteLine("4. Search the product by price");
            Console.WriteLine("5. Display all the product of Inventory");
            Console.WriteLine("6. Exit.");
            int op;
            do
            {
                Console.Write("Enter your choice:");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        UpdateQuantity();
                        break;
                    case 3:
                        Console.Write("Enter product name: ");
                        string product = Console.ReadLine();
                        FindProduct(product);
                        break;
                    case 4:
                        Console.Write("Enter product price: ");
                        double product1 = Convert.ToDouble(Console.ReadLine());
                        FindProduct(product1);
                        break;
                    case 5:
                        DisplayProduct();
                        break;

                }
            } while (op <= 5 && op > 0);
        }
    }
}
