using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    public class ConsoleReadWrite
    {
        public void PrintMenu()
        {
            int choice = 0;
            while (choice != 10)
            {
                //Product product = new Product();
                Menu();
                String flag = Console.ReadLine();
                Checks checks = new Checks();
                choice = checks.CheckInput(flag);
                List<BigInteger> fibonacciSeries = CountFirstTwoThouthand();
                WorlWithLINQ wl = new WorlWithLINQ();
                switch (choice)
                {
                    case 1:
                        {
                            PrintFibonacci(fibonacciSeries);
                            break;
                        }
                    case 2:
                        {
                            var result = wl.PrimeNumbers(fibonacciSeries);
                            PrintResult(result);
                            break;
                        }
                    case 3:
                        {
                            var result = wl.DivideBySum(fibonacciSeries);
                            PrintResult(result);
                            break;
                        }
                    case 4:
                        {
                            var result = wl.DivideByFive(fibonacciSeries);
                            PrintResult(result);
                            break;
                        }
                    case 5:
                        {
                            var result = wl.SquareRoots(fibonacciSeries);
                            PrintResult(result);
                            break;
                        }
                    case 6:
                        {
                            var result = wl.OrderBySecondNumber(fibonacciSeries);
                            PrintResult(result);
                            break;
                        }
                    case 7:
                        {
                            var result = wl.LastTwoNumbersDivideByThree(fibonacciSeries);
                            foreach (var i in result)
                            {
                                Console.WriteLine(i);
                            }
                            break;
                        }
                    case 8:
                        {
                            var result = wl.MaxSquareSum(fibonacciSeries);
                            Console.WriteLine($"number which has the largest sum of the squares of numbers is : {result}");
                            break;
                        }
                    case 9:
                        {
                            var result = wl.AverageWithZero(fibonacciSeries);
                            Console.WriteLine($"Average number of zeros is : {result}");
                            break;
                        }
                    case 10:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu item");
                            break;
                        }
                }
            }
        }


        public int CheckInput(string uncheckedString)
        {
            int checkedString;
            while (!int.TryParse(uncheckedString, out checkedString))
            {
                Console.WriteLine("Incorrect type, try again");
                uncheckedString = Console.ReadLine();
            }
            return checkedString;
        }

        public void Menu()
        {
            Console.WriteLine("1. Print Fibonachi.\n" +
                "2. Count prime numbers.\n" +
                "3. Calculate how many numbers are divided into the sum of its digits.\n" +
                "4. Calculate numbers, which are divided into 5.\n" +
                "5. Calculate the square roots of all the numbers that are a part of figure 2.\n" +
                "6. Sort by decreasing the number of the second digit.\n" +
                "7. Select the last 2 digits for all numbers that are divisible by 3 and among the closest neighbors which (5 in each direction) is at least one that is divisible by 5.\n" +
                "8. Count the number which has the largest sum of the squares of numbers.\n" +
                "9. Calculate the average number of zeros in the numbers\n" +
                "10. Exit.");
        }

        public void PrintFibonacci(List <BigInteger> series)
        {
            for (int i = 0; i < series.Count; i++)
            {
                Console.WriteLine($"{series[i]} ");
            }
        }

        public List<BigInteger> CountFirstTwoThouthand()
        {
            WorkWithFibonachi wf = new WorkWithFibonachi();
            List<BigInteger> list = new List<BigInteger>();
            for (int i = 1; i <= 200; i++)
            {
                BigInteger a = wf.CountFibonacci(i);
                list.Add(a);
            }
            return list;
        }

        public void PrintResult(List<BigInteger> result)
        {
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}
