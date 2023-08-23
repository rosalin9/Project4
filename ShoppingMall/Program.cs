using RetailStore;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Program
    {
        static List<ShoppingCart> Products = new List<ShoppingCart>();

        public static void AddToCart()
        {

            Console.Write("Enter the product to be added to the cart: ");
            string product = Console.ReadLine();
            Console.Write("No. of Items to be added: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Products.Add(new ShoppingCart(product, quantity));
            
        }

        public static void RemoveFromCart()
        {
            Console.Write("Enter the product name remove from the cart: ");
            string product = Console.ReadLine();
            ShoppingCart cart = Products.Find( x=> x.Product == product);
            Products.Remove(cart);
        }

        public static void DisplayCart()
        {
            Console.WriteLine("Product        Quantity");
            Console.WriteLine("------------------------");
            foreach (ShoppingCart cart in Products) 
            {
                Console.Write("{0,-20}",cart.Product);
                Console.WriteLine(cart.Quantity);
            }
        }

        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            Console.WriteLine("Welcome to Online Store!");
            Console.WriteLine();
            Console.WriteLine("Product            Price");
            Console.WriteLine("-------------------------");

            sortedList.Add("Apple", 7.50);
            sortedList.Add("Banana", 3.45);
            sortedList.Add("Orange", 5.80);
            sortedList.Add("Grapes", 6.50);
            sortedList.Add("Cherry", 8.70);
            sortedList.Add("Strawberry", 5.60);
            sortedList.Add("Avocado", 3.45);


            foreach (DictionaryEntry item in sortedList) 
            {
                Console.Write("{0,-20}",item.Key);
                Console.WriteLine(item.Value);
            }

            int op;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Add to cart");
                Console.WriteLine("2. Remove from cart");
                Console.WriteLine("3. Display cart");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                op= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (op)
                {
                    case 1:
                        AddToCart();
                        break;
                    case 2:
                        RemoveFromCart();
                        break;
                    case 3:
                        DisplayCart();
                        break;
                }

            } while (op > 0 && op < 4);

            double total = 0.0;

            if (Products.Count > 0) 
            {
                foreach(ShoppingCart pro in Products)
                {
                    if(sortedList.ContainsKey(pro.Product))
                    {
                        total += (pro.Quantity * Convert.ToDouble(sortedList[pro.Product]));
                    }
                   
                }


            }
            Console.WriteLine("Total price: " + total);

            Console.Read();
        }
    }
}
