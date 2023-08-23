using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantFood
{
    public class ResturantMenu
    {
        private string dishName;
        private double price;

        public string DishName 
        {
            get
            {
                return dishName;
            }
            set
            {
                dishName = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }


    }
    public class Apetizzer : ResturantMenu
    {
        public Apetizzer(string dishname, double price) 
        {
            DishName = dishname;
            Price = price;
        }
    }
    public class MainCourse : ResturantMenu
    {
        public MainCourse(string dishname, double price)
        {
            DishName = dishname;
            Price = price;
        }

    }
    public class Dessert : ResturantMenu
    {
        public Dessert(string dishname, double price)
        {
            DishName = dishname;
            Price = price;
        }
    }
}
