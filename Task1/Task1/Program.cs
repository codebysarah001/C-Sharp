using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Question -1 : Create console application that reads a string from the user and prints the same string

            Console.WriteLine("Please Enter Your Name : ");
            string userName = Console.ReadLine();

            Console.WriteLine("Your Name is " + userName);


            Console.WriteLine("");

            // Question -2 : Define variables with kind of : 
            //a.Double
            //b.String
            //c.Char
            //d.Bool
            //e.Int
            //f.Const
            //Then display it in console application

            double universityGrade = 84.9;
            Console.WriteLine("Your grade in university was : " + universityGrade);

            string petName = "Arya";
            Console.WriteLine("My cat's name is " + petName);

            char firstLetter = 's';
            Console.WriteLine("Your name start with :" + firstLetter);

            bool graduated = true;
            Console.WriteLine("Graduation status is :" + graduated);

            int age = 23;
            Console.WriteLine("I'm " + age + " years old!");

            const int id = 2000337005;
            Console.WriteLine("My national id is :" + id);


            Console.WriteLine("");

            // Question -3 : Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.

            string[] car = new string[] { "Ford Model T", "Volkswagen Beetle", "Toyota Corolla", "Ferrari 250 GTO", "Mini Cooper", "Porsche" };
            Console.WriteLine("Most 5 Famous cars in the world are :");

            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }

            Console.WriteLine("");

            // Question -4 : 4-	Write a program in C that reads a first name, surname and year of birth and display the names and the year one after another sequentially. Go to the editor
            //•	Input your firstname: Sami
            //•	Input your lastname: Ali
            //•	Input your year of birth: 1999
            //•	Sami Ali 1999

            string fName = "Noor";
            string lName = "Al-ali";
            int yearOfBirth = 2001;

            Console.Write(fName + " " + lName + " " + yearOfBirth);
            Console.WriteLine("");


            Console.WriteLine("");

            // Question -5 : 5-	Write a program in C # to store elements in an array and print it. 
            //•	Test Data :	
            //•	Input 10 elements in the array :
            //•	element - 0 : 1
            //•	element - 1 : 1
            //•	element - 2 : 2
            //•	.......
            //•	Expected Output :
            //•	Elements in array are: 1 1 2 3 4 5 6 7 8 9

            int[] printNumbers = new int[10];
            printNumbers[0] = 1;
            printNumbers[1] = 1;
            printNumbers[2] = 2;
            printNumbers[3] = 3;
            printNumbers[4] = 4;
            printNumbers[5] = 5;
            printNumbers[6] = 6;
            printNumbers[7] = 7;
            printNumbers[8] = 8;
            printNumbers[9] = 9;

            Console.WriteLine("Numbers : ");
            for (int i = 0; i < printNumbers.Length; i++)
            {
                Console.Write(printNumbers[i] + " ");
            }

            Console.WriteLine("");

            // Question -6 : Write a program in C# to find the sum of all elements of the array.
            //•	Test Data :
            //•	index - 0 : 2
            //•	index - 1 : 5
            //•	index - 2 : 8
            //•	Expected Output :
            //Sum of all elements stored in the array is : 15

            int[] sumOfArray = new int[] { 2, 5, 8 };

            int summation = 0;
            for (int i = 0; i < sumOfArray.Length; i++)
            {
                summation += sumOfArray[i];
            }
            Console.WriteLine("The sum of 2 , 5 , 8 is : " + summation);

            // Task : Read from the users strings and store them in array then sort them and print them 

            //string[] nameOfGroup = new string[5];

            //Console.WriteLine("Enter your team member 1 : ");
            //nameOfGroup[0] = Console.ReadLine();

            //Console.WriteLine("Enter your team member 2 : ");
            //nameOfGroup[1] = Console.ReadLine();

            //Console.WriteLine("Enter your team member 3 : ");
            //nameOfGroup[2] = Console.ReadLine();

            //Console.WriteLine("Enter your team member 4 : ");
            //nameOfGroup[3] = Console.ReadLine();

            //Console.WriteLine("Enter your team member 5 : ");
            //nameOfGroup[4] = Console.ReadLine();

            //Array.Sort(nameOfGroup);

            //for(int i = 0; i < nameOfGroup.Length; i++)
            //{
            //    Console.WriteLine(i + " " + nameOfGroup[i]);
            //}
        }
    }
}
