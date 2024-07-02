using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //o In the Main method, create instances of Dog and Cat.
            //o Call the Eat, Sleep, and MakeSound methods on each instance   

            Dog dog = new Dog("Bella");
            Cat cat = new Cat("Elsa");

            dog.Eat();
            Console.WriteLine();
            dog.Sleep();
            Console.WriteLine();
            dog.MakeSound();

            Console.WriteLine();

            cat.Eat();
            Console.WriteLine();
            cat.Sleep();
            Console.WriteLine();
            cat.MakeSound();


        }
    }
}
