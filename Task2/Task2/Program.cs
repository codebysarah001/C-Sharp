using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question -1 : 1.	Write a C# program that accept two integers and display the smaller. 

            //Console.WriteLine("Please enter number 1  : ");
            //string number1 = Console.ReadLine();
            //Console.WriteLine("Please enter number 2  : ");
            //string number2 = Console.ReadLine();


            //int num1 = Convert.ToInt32(number1);
            //int num2 = Convert.ToInt32(number2);


            //if(num1 < num2)
            //{
            //    Console.WriteLine($"The smaller number between {num1} and {num2} is : " + num1);
            //}
            //else if(num1 > num2)
            //{
            //    Console.WriteLine($"The smaller number between {num1} and {num2} is : " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("The numbers are equal!");
            //}


            //Console.WriteLine("");

            // second way :

            int integer = 25;
            int integer2 = 90;

            Console.WriteLine("The smallest number between 25 and 90 is :" + Math.Min(integer, integer2));

            Console.WriteLine();
            Console.WriteLine();



            // Question -2 : 2.	 Write a C# conditional statement to find the sign  of input  number. Display sign. Go 
            //•	Sample numbers: -7
            //•	Output: The sign is -

            //Console.Write("Enter a number to check the sign of it : ");
            //Console.WriteLine();
            //string num = Console.ReadLine();

            //int signNumber = Convert.ToInt32(num);
            //if (signNumber < 0)
            //{
            //    Console.WriteLine($"The sign of {signNumber} is : - ");
            //}
            //else if (signNumber > 0)
            //{
            //    Console.WriteLine($"The sign of {signNumber} is : + ");
            //}
            //else
            //{
            //    Console.WriteLine(signNumber);
            //}


            Console.WriteLine();

            // second way : 

            Console.Write("Enter a number to check the sign of it . ensure to put the sign before typing the number --> + or  - : ");
            Console.WriteLine();
            string number = Console.ReadLine();

            Console.WriteLine("The sign of number is : " + number[0]);

            Console.WriteLine();
            Console.WriteLine();


            // Qestion -3 : 3.	Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            //•	Sample numbers: 0, -1, 4
            //•	Output: 4, 0, -1

            // int number1 = 7;
            // int number2 = 9;
            // int number3 = 10;

            //if (number1 > number2 && number1 > number3)
            // {
            //     if (number2 > number3)
            //     {
            //         Console.WriteLine("Numbers after sorting is : " + number1 + " " + number2 + " " + number3);
            //     }
            //     else {
            //         Console.WriteLine("Numbers after sorting is : " + number1+ " " + number3 + " " + number2);
            //     }
            // }
            // else if (number2 > number1 && number2 > number3)
            // {
            //     if (number1 > number3)
            //     {
            //         Console.WriteLine("Numbers after sorting is : " + number2 + " " + number1 + " " + number3);
            //     }
            //     else
            //     {
            //         Console.WriteLine("Numbers after sorting is : " + number2 + " " + number3 + " " + number1);
            //     }
            // }
            // else if (number3 > number1 && number3 > number2)
            // {
            //     if (number1 > number2)
            //     {
            //         Console.WriteLine("Numbers after sorting is : " + number3 + " " + number1 + " " + number2);
            //     }
            //     else
            //     {
            //         Console.WriteLine("Numbers after sorting is : " + number3 + " " + number2 + " " + number1);
            //     }
            // }

            //Console.WriteLine();

            // second way : 

            int[] numbers = { 8, 3, 0 };

            Array.Sort(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine();
            Console.WriteLine();


            // Question -4 : 4.	Write a C# conditional statement to find the max of five numbers. Use console to display the result.
            //•	Sample numbers: -5, -2, -6, 0, -1
            //•	Output: 0

            int number1 = 0;
            int number2 = -1;
            int number3 = -2;
            int number4 = -5;
            int number5 = -6;

            int maxNumber = number1;

            if (number2 > maxNumber)
            {
                maxNumber = number2;
            }
            else if (number3 > maxNumber)
            {
                maxNumber = number3;
            }
            else if (number4 > maxNumber)
            {
                maxNumber = number4;
            }
            else if (number5 > maxNumber)
            {
                maxNumber = number5;
            }
            Console.WriteLine("The maximum number is : " + maxNumber);

            Console.WriteLine();


            // second way : 

            int[] maximumNumber = { 0, -1, -2, -5, -6 };
            Console.WriteLine("The maximum numbers is : " + maximumNumber.Max());

            Console.WriteLine();
            Console.WriteLine();

            // Question -5 : Write a C# program that converts kilometers per hour to miles per hour.  
            // Expected Output:
            //•	Input kilometers per hour: 15.
            //•	9.320568 miles per hour

            Console.WriteLine("Enter a kilometers per hour to convert it into miles :");
            string kiloMeters = Console.ReadLine();

            double convertKilometers = Convert.ToDouble(kiloMeters);
            convertKilometers *= 0.621371;

            Console.WriteLine($"{kiloMeters} in miles is = " + convertKilometers);

            Console.WriteLine();

            // Question -6 : Write a C# program that takes hours and minutes as input and calculates the total number of minutes.
            //•	Input hours: 5
            //•	Input minutes: 37
            //•	Total: 337 minutes.

            //Console.WriteLine("Enter the numbers of hours : ");
            //string hours = Console.ReadLine();

            //Console.WriteLine("Enter the numbers of minutes : ");
            //string minutes = Console.ReadLine();

            //int convertHours = Convert.ToInt32(hours);
            //int convertMinutes = Convert.ToInt32(minutes);

            //int Total = (60 * convertHours) + convertMinutes;
            //Console.WriteLine("The total minutes is : " + Total);

            //Console.WriteLine();

            // Question -7 : 7.	Write a program in C# that takes minutes as input and display the total number of hours and minutes. 
            //•	Input minutes: 546
            //•	9 Hours, 6 Minutes


            Console.WriteLine("Enter the numbers of minutes : ");
            string input = Console.ReadLine();

            int convertMinutes = Convert.ToInt32(input);
            int hours = convertMinutes / 60;
            int minutes = convertMinutes % 60;
            Console.WriteLine($"{hours} Hours, {minutes} Minutes");

            Console.WriteLine();

            // Question -8 : 8.	Create string of array that contains 5 element of different sentence with different length .
            //Print all elements with fixed length for each sentence.

            //string[] sentences = new string[] {"My name is Sarah", "I'm 23 years old", "graduated form Yarmouk University.",
            //"I have 2 cats,", "The mothers's name is Elsa", "and her son Leo"};

            //for (int i = 0; i < sentences.Length; i++)
            //{
            //    string sentence = sentences[i];
            //    Console.WriteLine(sentence + "   .The lenght of this sentence is : " + sentence.Length);
            //    Console.WriteLine();
            //}

            //second way : 

            string[] sentences = new string[] {"My name is Sarah", "I'm 23 years old", "graduated form Yarmouk University.",
            "I have 2 cats,", "The mothers's name is Elsa", "and her son Leo"};

            string str1 = sentences[0];
            string str2 = sentences[1];
            string str3 = sentences[2];
            string str4 = sentences[3];
            string str5 = sentences[4];
            string str6 = sentences[5];

            Console.WriteLine(str1.Substring(0, 10) + str2.Substring(0, 10) + str3.Substring(0, 10) + str4.Substring(0, 10) + str5.Substring(0, 10));

        }
    }
    
}