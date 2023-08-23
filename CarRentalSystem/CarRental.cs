using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class CarRental
    {
        public string CarBrand;
        public string CarModel;
        public int Year;
        public string Status;
        public double Price;

               
        public CarRental(string carBrand, string carModel, int year, string status, double price)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            Year = year;
            Status = status;
            Price = price;
        }
    }


}
