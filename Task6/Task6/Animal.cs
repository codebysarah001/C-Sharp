using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task6
{
    // Create an interface named ISound that includes a method void MakeSound();.
    public interface ISound
    {
        void MakeSound();

    }

    // 2. Create an abstract class named Animal that includes:

    //	A property string Name { get; set; }.
    //	A constructor that takes a string name parameter and sets the Name property.
    //	An abstract method void Eat();.
    //	A concrete method void Sleep() that prints out the animal's name followed by "is sleeping.".

    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {

            Name = name;
        }

        public abstract void Eat();

        public void Sleep()
        {
            Console.WriteLine(Name + " is sleeping.");
        }
    }

    //3.  Create two classes, Dog and Cat.

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public override void Eat()
        {

            Console.WriteLine(Name + " is eating a dog's food");
        }

        public void MakeSound()
        {
            Console.WriteLine(Name + " says : Woof!");
        }
    }

    public class Cat : Animal, ISound
    {
        public Cat(string name) : base(name)
        {

        }

        public override void Eat()
        {
            Console.WriteLine(Name + " is eating Friskies wet food.");
        }

        public void MakeSound()
        {
            Console.WriteLine(Name + " says : Meaw!");
        }
    }



}
