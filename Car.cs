using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet_week6
{
    internal class Car
    {
        private String brand;
        private int year;
        private float price;

        public Car(String brand, int year, float price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;

        }

        public void PrintCarDetails()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Price: {price}");
        }

    }
}
