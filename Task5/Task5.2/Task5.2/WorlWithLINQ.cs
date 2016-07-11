using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    public  class WorlWithLINQ
    {

        public List<BigInteger> PrimeNumbers(List<BigInteger> FibonacciSeries)
        {
            var res = FibonacciSeries.Where(n => n.IsProbablePrime(10)).ToList();
            return res;
        }

       
        public bool DivideByFive(List<BigInteger> FibonacciSeries)
        {
            var result = FibonacciSeries.Any(n => n%5 == 0);
            return result;
        }

        public List<BigInteger> DivideBySum(List<BigInteger> FibonacciSeries)
        {
            var res = FibonacciSeries
                .Where(n => n % (n.ToString().Sum(c => c - '0')) == 0)
                .ToList();
            return res;
        }

        public List<BigInteger> SquareRoots(List<BigInteger> FibonacciSeries)
        {
            
            var res = FibonacciSeries
                .Where(n => n.ToString().Contains('2'))
                .Select (n => (BigInteger)Math.Exp(BigInteger.Log(n) / 2)).ToList();
            return res;
             
        }

        public BigInteger MaxSquareSum (List<BigInteger> FibonacciSeries)
        {

            var res = FibonacciSeries
                .OrderByDescending(n => (n.ToString().Sum(c => (c - '0')* (c - '0')))).First();
               
            return res;
        }

        public List<BigInteger> OrderBySecondNumber(List<BigInteger> FibonacciSeries)
        {
            var res = FibonacciSeries
                .Where(n => n.ToString().Length > 1)
                .OrderByDescending(n => (n.ToString().ElementAt(1))).ToList();
            return res;
        }

        public double AverageWithZero(List<BigInteger> FibonacciSeries)
        {
            var res = FibonacciSeries
                .Select(n => n.ToString().Count(c => c == '0')).ToList().Average();
            return res;
        }

        public List<String> LastTwoNumbersDivideByThree(List<BigInteger> FibonacciSeries)
        {
            var result = FibonacciSeries
                .Where(n => (n % 3 == 0) && (n.ToString().Length > 1))
                .Select(n => n.ToString().Substring(n.ToString().Length - 2))
                .ToList();
            return result;
        }

    }
}
