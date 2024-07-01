using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Car
    {
        // 1.Implement a Car class which has fields to store the car's make, year, Type, Price, model, Pallet No, and color
        protected string type;
        protected string model;
        protected int year;
        protected int price;
        protected string color;
        protected string palletNo;

        // 2.Implement a constructor for the car class which takes parameters corresponding to each of the fields above and constructs an object with these values

        public Car(string type, string model, int year, int price, string color, string palleteNo)
        {
            this.type = type;
            this.model = model;
            this.year = year;
            this.price = price;
            this.color = color;
            this.palletNo = palleteNo;
        }

        // 3. Implement a method to start and stop engine.

        public void Start()
        {
            Console.WriteLine("The car starts.");
        }

        public void Stop()
        {
            Console.WriteLine("The car stops!");
        }

        // 4. Try to return a string containing full information about the car

        public string DisplayInformation()
        {
            return $"The type of the car is {this.type}, the model is {this.model}, the year is {this.year}, the price is {this.price}, the color is {this.color} and the pallete number is : {this.palletNo}";
        }

    }

        // 5 Apply inheritance for the base class (create class BMW (Derived Class))

        class BMW : Car
        {
            public BMW(string modale, int year, int price, string color, string palletNo)
                    : base("BMW", modale, year, price, color, palletNo)
            {
            }
        }
}
