using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Program
    {
        static Dictionary<int, CarRental> dict = new Dictionary<int, CarRental>();

        static void AvailableCar()
        {
            
            Console.WriteLine("Serial    Brand       Model        Year      Availablity        Price ");
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (var kvp in dict)
            {
                if (kvp.Value.Status == "Available")
                {
                    Console.Write("{0,-10}", kvp.Key);
                    Console.Write("{0,-15}", kvp.Value.CarBrand);
                    Console.Write("{0,-20}", kvp.Value.CarModel);
                    Console.Write("{0,-10}", kvp.Value.Year);
                    Console.Write("{0,-20}", kvp.Value.Status);
                    Console.WriteLine(kvp.Value.Price);

                }
            }
        }
        static void RentCar()
        {
            Console.Write("Enter the model name for rent: ");
            string car = Console.ReadLine();

            foreach (var kvp in dict)
            {
                if(kvp.Value.Status.Contains("Available") && kvp.Value.CarModel.Contains(car))
                {
                    Console.WriteLine("Come & Collect your car");
                    kvp.Value.Status = "Unavailable";
                    break;
                }

            }
            
        }
        static void ReturnCar()
        {
            Console.Write("Enter the model name which is returned: ");
            string car = Console.ReadLine();

            foreach(var kvp in dict)
            {
                if(kvp.Value.CarModel.Contains(car)) 
                {
                    kvp.Value.Status = "Available";
                    Console.WriteLine("{0} model is available now",kvp.Value.CarModel);
                    break;
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Car Rental!");
            Console.WriteLine();

            dict.Add(1, new CarRental("Tesla", "X", 2023, "UnAvailable", 45.50));
            dict.Add(2, new CarRental("Tesla", "S", 2022, "Available", 42.50));
            dict.Add(3, new CarRental("Tesla", "Y", 2021, "Available", 40.50));
            dict.Add(4, new CarRental("Toyota", "Highlander", 2023, "UnAvailable", 40.00));
            dict.Add(5, new CarRental("Toyota", "bZ3", 2022, "Available", 38.50));
            dict.Add(6, new CarRental("Toyota", "RAV4", 2018, "Available", 35.00));
            dict.Add(7, new CarRental("Toyota", "Fortuner", 2015, "UnAvailable", 36.50));
            dict.Add(8, new CarRental("BMW", "X5", 2019, "Available", 37.50));
            dict.Add(9, new CarRental("BMW", "X6", 2020, "Available", 40.50));
            dict.Add(10, new CarRental("BMW", "X7", 2022, "UnAvailable", 45.50));

            Console.WriteLine("1. Cars which are Available");
            Console.WriteLine("2. Rent a Car");
            Console.WriteLine("3. Return a Car");
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
                        AvailableCar();
                        break;
                    case 2:
                        RentCar();
                        break;
                    case 3:
                        ReturnCar();
                        break;

                }
            } while (op > 0 && op < 4);


        }
    }
}
