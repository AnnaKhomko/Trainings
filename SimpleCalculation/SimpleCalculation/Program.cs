using System;
using Calculator;
using System.Configuration;

namespace SimpleCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double  sum, diff, comp, quotient;
            long a, b;

            Calculation calc = new Calculation();
            if (bool.Parse(ConfigurationManager.AppSettings["UsingConsole"]).Equals(true))
            {
                if (bool.Parse(ConfigurationManager.AppSettings["UsingLibrary"]).Equals(true))
                {
                    Console.WriteLine("Enter first number:");
                    while (!long.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Sorry, it is not a number, try again");
                        
                    }
                    Console.WriteLine("Enter second number:");

                    while (!long.TryParse(Console.ReadLine(), out b));
                    {
                        Console.WriteLine("Sorry, it is not a number, try again");
                                            }
                    sum = calc.Addition(a, b);
                    diff = calc.Subtraction(a, b);
                    comp = calc.Multiplication(a, b);
                    quotient = calc.Division(a, b);
                    Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
                }
                else
                {
                    Console.WriteLine("Enter first number:");
                    while (!long.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Sorry, it is not a number, try again");

                    }
                    Console.WriteLine("Enter second number:");

                    while (!long.TryParse(Console.ReadLine(), out b)) ;
                    {
                        Console.WriteLine("Sorry, it is not a number, try again");
                    }
                    sum = Addition(a, b);
                    diff = Subtraction(a, b);
                    comp = Multiplication(a, b);
                    quotient = Division(a, b);
                    Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
                }
                

            }
            else if (bool.Parse(ConfigurationManager.AppSettings["UsingLibrary"]).Equals(true))
            {

                long.TryParse((Resource1.FirstNumber),out a);
                long.TryParse((Resource1.FirstNumber), out b);
                sum = calc.Addition(a, b);
                diff = calc.Subtraction(a, b);
                comp = calc.Multiplication(a, b);
                quotient = calc.Division(a, b);
                Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
            }
            else
            {

                long.TryParse((Resource1.FirstNumber), out a);
                long.TryParse((Resource1.FirstNumber), out b);
                sum = Addition(a, b);
                diff = Subtraction(a, b);
                comp = Multiplication(a, b);
                quotient = Division(a, b);
                Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
            }
            
           
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }

        static double Addition(long a, long b)
        {
            return a + b;
        }

        static double Subtraction(long a, long b)
        {
            return a - b;
        }

        static double Multiplication(long a, long b)
        {
            return a * b;
        }

        static double Division(long a, long b)
        {
            return a / b;
        }
    }
}

