using System;
using Calculator;

namespace SimpleCalculation
{
    class ActionUtil
    {
        double sum, diff, comp, quotient;
        long a, b;

        public void DoConsole()
        {
            Console.WriteLine("Enter first number:");
            while (!long.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Sorry, it is not a number, try again");

            }
            Console.WriteLine("Enter second number:");

            while (!long.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Sorry, it is not a number, try again");
            }
        }

        public void DoResource()
        {
            long.TryParse((Resource1.FirstNumber), out a);
            long.TryParse((Resource1.FirstNumber), out b);
        }

        public void CalculateExternal()
        {
            Calculation calc = new Calculation();
            sum = calc.Add(a, b);
            diff = calc.Subtract(a, b);
            comp = calc.Multiplicate(a, b);
            quotient = calc.Divide(a, b);
            Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
        }

        public void CalculateInternal()
        {
            sum = MathCalculation.Add(a, b);
            diff = MathCalculation.Subtract(a, b);
            comp = MathCalculation.Multiplicate(a, b);
            quotient = MathCalculation.Divide(a, b);
            Console.WriteLine("Sum: {0}, Subtraction: {1}, Multiplication: {2}, Division: {3}", sum, diff, comp, quotient);
        }
    }
}
