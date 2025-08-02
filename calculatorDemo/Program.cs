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
            string choice;
            do
            {
                Console.Write("What is the first number: ");
                string firstMumber = Console.ReadLine();
                int num1 = int.Parse(firstMumber);

                Console.Write("Choose +, -, /, *: ");
                char function = Console.ReadLine()[0];

                Console.Write("What is the second number: ");
                string secondMumber = Console.ReadLine();
                int num2 = int.Parse(secondMumber);
                Console.WriteLine();
                Console.WriteLine();


                if (function == '+')
                {
                    int result = calculation.Add(num1, num2);
                    Console.WriteLine($"{num1} + {num2} = {result}");
                }
                else if (function == '-')
                {
                    int result = calculation.Subtract(num1, num2);
                    Console.WriteLine($"{num1} - {num2} = {result}");
                }
                else if (function == '*')
                {
                    int result = calculation.Multiply(num1, num2);
                    Console.WriteLine($"{num1} * {num2} = {result}");
                }
                else if (function == '/')
                {
                    double result = calculation.Divide(num1, num2);
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please choose +, -, /, or *.");
                } 
                Console.WriteLine();
                Console.Write("Would you like to perform another calculation? (yes/no): ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "yes");

            Console.WriteLine("Thank you for using the Calculator Demo!");
            //Console.WriteLine("Would you like to add another number to the equation? ( yes /no)");
            //string additionalNumber = Console.ReadLine();
            Console.ReadLine();

        }
    }
}
