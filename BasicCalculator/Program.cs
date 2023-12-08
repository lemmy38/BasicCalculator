using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public class Program
    {
        static void Main(string[] args)

        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            do
            {

                Console.WriteLine("________________________________________");

                Console.WriteLine("Welcome to my Simple Calculator Program ");

                Console.WriteLine("By Lindiwe Isiwele");

                Console.WriteLine("________________________________________");

                //user to enter the numbers to be calculated 
                Console.Write("Please enter number 1:  ");

                 num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter number 2:  ");
                 num2 = Convert.ToInt32(Console.ReadLine());

                //User to choose math operator option 
                Console.WriteLine("Please enter an  option: ");
                Console.WriteLine("\t + : Add");
                Console.WriteLine("\t - : Subtract");
                Console.WriteLine("\t / : divide");
                Console.WriteLine("\t *: Multiply");

                Console.Write("Enter a Option  ");

                switch (Console.ReadLine())

                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;

                    case "*":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;


                    default:
                        Console.WriteLine("you enter an invalid number");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = No):");

            } while (Console.ReadLine().ToUpper() == "Y");



            Console.WriteLine("Bye");

            Console.ReadKey();

        }


    }
}










