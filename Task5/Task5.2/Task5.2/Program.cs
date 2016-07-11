using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithFibonachi wf = new WorkWithFibonachi();
            WorlWithLINQ wl = new WorlWithLINQ();
            List<BigInteger> list = new List<BigInteger>();
                for (int i = 1; i <= 200; i++)
            {
                BigInteger a = wf.CountFibonacci(i);
                list.Add(a);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i]} ");
            }

            var result = wl.PrimeNumbers(list);
            //var result = wl.DivideForSum(list);
            //var result = wl.OrderBySecondNumber(list);
            //var result = wl.SquareRoots(list);
            //var result = wl.AverageWithZero(list);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //Console.WriteLine(wl.MaxSquareSum(list));
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
