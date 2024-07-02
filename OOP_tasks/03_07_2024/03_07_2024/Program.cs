using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_07_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW myBMW = new BMW("BMW", 2021, "SUV", 50000, "X5", 5678, "Black");

            myBMW.Display();

        }
    }
}
