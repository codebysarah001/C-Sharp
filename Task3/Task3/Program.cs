using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question -1 : Correct the syntax error:

            //•	string[] ARR = [1, 7  9  45,]
            //•	int arr2 = ["Str" "alex","moh"
            //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ] :

            // 1 :
            int[] ARR = { 1, 7, 9, 45 };

            // 2 :
            string[] arr2 = { "Str", "alex", "moh" };

            // 3 :
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            //////////////////////////////////////////////////////


            // Question -2 : What the index of "Banana","Tomato"?
            //String[] fruits = ["Tomato", "Banana", "Watermelon"]

            String[] fruits = { "Tomato", "Banana", "Watermelon" };

            Console.WriteLine("What the index of \"Banana\",\"Tomato\"?");

            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Banana")
                {
                    Console.WriteLine($"The index of Banana is : {i}");
                }
                else if (fruits[i] == "Tomato")
                {
                    Console.WriteLine($"The index of Tomato is : {i}");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            /////////////////////////////////////////////////////////


            // Question -3 : Create an multiple arrays that represents your:
            //•	Favorite Food(5 item)
            //•	Favorite Sport(3 item)
            //•	Favorite Movie(4 item)
            //Then, print each array using foreach, and Loop Through an Array


            string[] favoriteFood = { "Mansaf", "Kbab", "Mandi", "Taboleh", "Maklobeh" };

            for (int i = 0; i < favoriteFood.Length; i++)
            {

                Console.WriteLine($"My Top {i + 1} favorite food is : {favoriteFood[i]}");

            }

            Console.WriteLine();
            Console.WriteLine();

            string[] favoriteSport = { "walking", "swimming", "none" };

            for (int i = 0; i < favoriteSport.Length; i++)
            {

                Console.WriteLine($"My Top {i + 1} favorite sport is : {favoriteSport[i]}");

            }

            Console.WriteLine();
            Console.WriteLine();

            string[] favoriteMovie = { "London has fallen", "Zaki Shan", "The Shawshank Redemption", "Need for speed" };

            for (int i = 0; i < favoriteMovie.Length; i++)
            {

                Console.WriteLine($"My Top {i + 1} favorite movie is : {favoriteMovie[i]}");

            }

            Console.WriteLine();
            Console.WriteLine();

            /////////////////////////////////////////////////////////


            // Questio -4 : Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            //•	Expected Output:
            //•	Input three numbers separated by comma: 5,10,15
            //•	The sum of three numbers: 30.

            Console.Write("Plese enter three numbers to calculate the sum of them : ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');

            int sum = 0;

            foreach (string i in numbers)
            {

                sum += int.Parse(i.Trim());

            }
            Console.WriteLine("The sum of numbers is : " + sum);

            Console.WriteLine();
            Console.WriteLine();

            /////////////////////////////////////////////////////////


            // Question 5- : Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            //•	Test Data
            //•	The odd numbers are1 3 5 7 9 11 13 15 17 19……
            //•	The Sum of odd Numbers is: …...

            int oddNumbersSum = 0;
            string oddNumbers = "";
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbersSum += i;
                    oddNumbers += i + " ";
                }
            }
            Console.WriteLine("The odd numbers are : " + oddNumbers);
            Console.WriteLine("The sum of odd numbers is : " + oddNumbersSum);

            Console.WriteLine();
            Console.WriteLine();

            /////////////////////////////////////////////////////////


            // Question 6- :  Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
            //   The pattern like:
            //   *
            //  **
            // *
            //**

            string star ="*";

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(star + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();


            // another way : 

            string x = "*";
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(x);
                x += "*";
            }

            Console.WriteLine();

            /////////////////////////////////////////////////////////


            // Question -7 : Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            //The pattern like:

            //1
            //2 3
            //4 5 6
            //7 8 9 10


            int number_1 = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4-i ; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1;k <= i; k++)
                {
                    Console.Write(number_1 + " ");
                    number_1++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("END !!!!");


        }
    }
}