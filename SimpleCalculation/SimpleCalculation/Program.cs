using System;
using Calculator;
using System.Configuration;

namespace SimpleCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, diff, comp, quotient;
            Calculation calc = new Calculation();
            if (bool.Parse(ConfigurationManager.AppSettings["UsingConsole"]).Equals(true))
            {
                if (bool.Parse(ConfigurationManager.AppSettings["UsingLibrary"]).Equals(true))
                {
                    Console.WriteLine("Enter first number:");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    b = Int32.Parse(Console.ReadLine());
                    sum = calc.Addition(a, b);
                    diff = calc.Subtraction(a, b);
                    comp = calc.Multiplication(a, b);
                    quotient = calc.Division(a, b);
                    Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
                }
                else
                {
                    Console.WriteLine("Enter first number:");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    b = Int32.Parse(Console.ReadLine());
                    sum = Addition(a, b);
                    diff = Subtraction(a, b);
                    comp = Multiplication(a, b);
                    quotient = Division(a, b);
                    Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
                }
                

            }
            else if (bool.Parse(ConfigurationManager.AppSettings["UsingLibrary"]).Equals(true))
            {
                
                a = Int32.Parse(Resource1.FirstNumber);
                b = Int32.Parse(Resource1.SecondNumber);
                sum = calc.Addition(a, b);
                diff = calc.Subtraction(a, b);
                comp = calc.Multiplication(a, b);
                quotient = calc.Division(a, b);
                Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
            }
            else
            {

                a = Int32.Parse(Resource1.FirstNumber);
                b = Int32.Parse(Resource1.SecondNumber);
                sum = Addition(a, b);
                diff = Subtraction(a, b);
                comp = Multiplication(a, b);
                quotient = Division(a, b);
                Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
            }
            
           
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }

        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static int Division(int a, int b)
        {
            return a / b;
        }
    }
}

