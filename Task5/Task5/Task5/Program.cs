using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calling the classes 

            Car car = new Car("mercedes", "benz", 2022, 20000, "red", "4-8");

            Console.WriteLine(car.DisplayInformation());

            BMW bmw = new BMW("X7", 2022, 80000, "red", "4-8");

            Console.WriteLine(bmw.DisplayInformation());
        }
    }
}
