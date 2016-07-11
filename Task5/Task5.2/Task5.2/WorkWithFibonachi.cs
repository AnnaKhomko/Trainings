using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task5._2
{
    public class WorkWithFibonachi
    {
        public BigInteger CountFibonacci(int n)
        {
            BigInteger a = BigInteger.Zero;
            BigInteger b = BigInteger.One;
            for (int i = 31; i >= 0; i--)
            {
                BigInteger d = a *(b * 2 - a);
                BigInteger e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)n >> i) & 1) != 0)
                {
                    BigInteger c = a + b;
                    a = b;
                    b = c;
                }
            }
            return a;
        }

        public List<BigInteger> CountFirstTwoThouthand(BigInteger a)
        {
            List<BigInteger> fibonachiNumbers = new List<BigInteger>();
            fibonachiNumbers.Add(a);
           
            return fibonachiNumbers;
        }
    }
}
