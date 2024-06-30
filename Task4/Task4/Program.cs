using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FIRST TASK : Write a function in C# that accept 10 numbers and return sum and average.

            (double summation, double average) SumAndvAerage(double[] tenNumbers)
            {
                double summation = 0;
                for (int i = 0; i < tenNumbers.Length; i++)
                {
                    summation += tenNumbers[i];
                }
                double average = summation / tenNumbers.Length;
                return (summation, average);
            }

            // calling task 1 :

            double[] numbers = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };
            var result = SumAndvAerage(numbers);

            Console.WriteLine("The sum is :" + result.summation);
            Console.WriteLine("The average is : "+result.average);

            Console.WriteLine();
            Console.WriteLine();

            // SECOND TASK : Write a program in C# to display the cube of the number up to given an integer.

            double Cube(double number)
            {
                return (number * number * number);
            }

            // calling task 2 :

            Console.Write("Enter a number to find its cube:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The cube of {num} is {Cube(num)}");

            Console.WriteLine();
            Console.WriteLine();

            // THIRD TASK : Write a program in C# return only numbers in the years array greater than 1950.

            int[] getYears(int [] years)
            {
                int count = 0;
                for(int i = 0;i <years.Length; i++)
                {
                    if (years[i] > 1950)
                    {
                        count++;
                    }
                }

                int[] yearsAfter1950 = new int[count]; // store years inside of it
               
                int index = 0;

                foreach (int year in years) { 
                    if(year > 1950)
                    {
                        yearsAfter1950[index] = year;
                        index++;
                    }
                }
                return yearsAfter1950;
            }

            // CALLING TASK 3 :

            int[] y = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int[] yearGreater_1950 = getYears(y);

            Console.WriteLine("Years greater than 1950:");
            foreach (int i in yearGreater_1950) {

                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine();

            // TASK 4 : Create a function that takes the age in years and returns the age in days.

            int yearsToDays(int year)
            {
                return year * 365;
            }

            // CALL TASK 4 :

            Console.Write("Enter your year of birth : ");
            int yearInput = Convert.ToInt32(Console.ReadLine());

            int days = yearsToDays(yearInput);
            Console.WriteLine($"{yearInput} in days is {days} days");

            Console.WriteLine();
            Console.WriteLine();


            // Task 5 : 5-	Create class that contain the following field:
            //a.Age  between 18 - 60
            //b.Gender
            //c.Name
            //d.E - Mail
            //e.ID
            //f.Phoneshould be started in 077 or 078 or 079
            //Don’t forget the default value.

            // calling :

            information person1 = new information();
            Console.WriteLine("Person 1: ");
            person1.Display();
            Console.WriteLine();

            information person2 = new information("Noor", "Noor@gmail.com", "Female", "1234", "07846329400", 23);
            Console.WriteLine("person 2 :");
            person2.Display(); 
            Console.WriteLine();

        }
    }
}
