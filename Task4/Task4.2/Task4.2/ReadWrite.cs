using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    public class ReadWrite
    {
        public void ReadIndexForFibonachi()
        {
            FibonachiAndFactorial fibAndFact = new FibonachiAndFactorial();
            CheckExceptions check = new CheckExceptions();
            string index;
            Console.WriteLine("Enter index to count Fibonachi");
            index = Console.ReadLine();
            int checkedIndex;
            while (!int.TryParse(index, out checkedIndex) || !check.CheckNegativeIndex(checkedIndex))
            {
                Console.WriteLine("Incorrect index, try to enter again");
                index = Console.ReadLine();
            }
            Console.WriteLine($"Fibonachi: {fibAndFact.Fib(checkedIndex)}");
            
        }

        public void ReadIndexForFactorial()
        {
            FibonachiAndFactorial fibAndFact = new FibonachiAndFactorial();
            CheckExceptions check = new CheckExceptions();
            string index;
            Console.WriteLine("Enter index to count Factorial");
            index = Console.ReadLine();
            int checkedIndex;
            while (!int.TryParse(index, out checkedIndex) || !check.CheckNegativeIndex(checkedIndex))
            {
                Console.WriteLine("Incorrect index, try to enter again");
                index = Console.ReadLine();
            }
            Console.WriteLine($"Factorial: {fibAndFact.FactTree(checkedIndex)}");
            
        }
        
    }
}
