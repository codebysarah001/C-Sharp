using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_07_2024
{
    public class Car
    {
        string Make { get; set; }
        int Year { get; set; }
        string Type { get; set; }
        double Price { get; set; }
        string Model { get; set; }
        int PalletNo { get; set; }

        string Color { get; set; }

        public Car(string make, int year, string type, double price, string model, int palletNo, string color)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
        }

        public void DisplayInfo(string make, string year)
        {
            Console.WriteLine($"Make: {make}, Year: {year}");
        }

        public void DisplayInfo(string make)
        {
            Console.WriteLine($"Make: {make}");
        }

        public virtual void Display()
        {
            Console.WriteLine("Welcome Car");
        }

    }

    public class BMW : Car
    {
        public BMW(string make, int year, string type, double price, string model, int palletNo, string color)
            : base(make, year, type, price, model, palletNo, color)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Welcome BMW");
        }


    }
}
