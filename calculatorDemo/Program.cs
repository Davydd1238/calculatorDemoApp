using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace calculatorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionModel calculation = new FunctionModel();

            Console.WriteLine("Welcome to the Calculator Demo by Josh Blau");
                        
            Console.WriteLine("What function would you like to compute:");
            string function = Console.ReadLine();
            
            
            Console.WriteLine("What is the first number:");
            string firstMumber = Console.ReadLine();
            int num1 = int.Parse(firstMumber);

            
            Console.WriteLine("What is the second number:");
            string secondMumber = Console.ReadLine();
            int num2 = int.Parse(secondMumber);

            
            //Console.WriteLine("Would you like to add another number to the equation? ( yes /no)");
            //string additionalNumber = Console.ReadLine();

            Console.WriteLine($"The total is . ");
            Console.ReadLine();

        }
    }
}
