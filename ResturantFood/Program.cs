using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantFood
{
    

    public class Program
    {
        static Dictionary<int, Apetizzer> dish1 = new Dictionary<int, Apetizzer>();
        static Dictionary<int, MainCourse> dish2 = new Dictionary<int, MainCourse>();
        static Dictionary<int, Dessert> dish3 = new Dictionary<int, Dessert>();


        static void AddMenu()
        {
            Console.WriteLine("1. Add in Apetizzer");
            Console.WriteLine("2. Add in Main Course");
            Console.WriteLine("3. Add in Dessert");
            Console.WriteLine("4. Exit");
            int op;
            int i = 7, j = 6, k = 3;
            
                Console.Write("Enter your option(To add in Apetizzer/Main course/Dessert): ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("Enter the dish name to add in the menu: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter the price: ");
                        double val = Convert.ToDouble(Console.ReadLine());
                        i += 1;
                        dish1.Add(i, new Apetizzer(name, val));
                        break;
                    case 2:
                        Console.Write("Enter the dish name to add in the menu: ");
                        string name1 = Console.ReadLine();
                        Console.Write("Enter the price: ");
                        double val1 = Convert.ToDouble(Console.ReadLine());
                        j += 1;
                        dish2.Add(j, new MainCourse(name1, val1));
                        break;
                    case 3:
                        Console.Write("Enter the dish name to add in the menu: ");
                        string name2 = Console.ReadLine();
                        Console.Write("Enter the price: ");
                        double val2 = Convert.ToDouble(Console.ReadLine());
                        k += 1;
                        dish3.Add(k, new Dessert(name2, val2));
                        break;

                }
            
        }

        static void UpdatePrice()
        {
            Console.Write("Enter the menu name whose price will be updated: ");
            string name = Console.ReadLine();
            foreach (var item in dish1.Values)
            {
                if (item.DishName.Contains(name))
                {
                    Console.Write("Enter the updated price: ");
                    item.Price = Convert.ToDouble(Console.ReadLine());
                    break;
                }
            }
            foreach (var item in dish2.Values)
            { 
                if (item.DishName.Contains(name))
                {
                    Console.Write("Enter the updated price: ");
                    item.Price = Convert.ToDouble(Console.ReadLine());
                    break;
                }

            }
            foreach (var item in dish3.Values)
            {
                if (item.DishName.Contains(name))
                {
                    Console.Write("Enter the updated price: ");
                    item.Price = Convert.ToDouble(Console.ReadLine());
                    break;
                }

            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Serial              Dish Name                 Price");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("APETIZZER: ");
            Console.WriteLine();
            foreach (var kvp in dish1)
            {
                
                    Console.Write("{0,-20}", kvp.Key);
                    Console.Write("{0,-25}", kvp.Value.DishName);
                    Console.WriteLine(kvp.Value.Price);
            }

            Console.WriteLine("Main Course: ");
            Console.WriteLine();
            foreach (var kvp in dish2)
            {

                Console.Write("{0,-20}", kvp.Key);
                Console.Write("{0,-25}", kvp.Value.DishName);
                Console.WriteLine(kvp.Value.Price);
            }

            Console.WriteLine("DESSERT: ");
            Console.WriteLine();
            foreach (var kvp in dish3)
            {

                Console.Write("{0,-20}", kvp.Key);
                Console.Write("{0,-25}", kvp.Value.DishName);
                Console.WriteLine(kvp.Value.Price);
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Resturant!");
            Console.WriteLine();
            dish1.Add(1, new Apetizzer("Chicken 65", 14.50));
            dish1.Add(2, new Apetizzer("Gobi 65", 12.00));
            dish1.Add(3, new Apetizzer("American crispy corn", 14.00));
            dish1.Add(4, new Apetizzer("Chicken Tandoor", 16.00));
            dish1.Add(5, new Apetizzer("Paneer 65", 14.00));
            dish1.Add(6, new Apetizzer("Chilli Paneer", 14.50));
            dish1.Add(7, new Apetizzer("Chilli Gobi", 12.50));

            dish2.Add(1, new MainCourse("Chicken Biriyani", 16.00));
            dish2.Add(2, new MainCourse("Veg Biriyani", 14.00));
            dish2.Add(3, new MainCourse("Kadhai Chicken", 15.00));
            dish2.Add(4, new MainCourse("Mixveg Curry", 14.00));
            dish2.Add(5, new MainCourse("Paneer Butter Masala", 14.00));
            dish2.Add(6, new MainCourse("Dal Makhani", 14.00));

            dish3.Add(1, new Dessert("Kheer", 12.00));
            dish3.Add(2, new Dessert("Gajar Halwa", 13.00));
            dish3.Add(3, new Dessert("Gulab Jamun", 13.50));

            Console.WriteLine("1. Display the Menu");
            Console.WriteLine("2. Add new item in the Menu");
            Console.WriteLine("3. Update the item price");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            int op;
            do
            {
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        DisplayMenu();
                        break;
                    case 2:
                        AddMenu();
                        break;
                    case 3:
                        UpdatePrice();
                        break;

                }
            } while (op > 0 && op < 4);


        }
    }
}
