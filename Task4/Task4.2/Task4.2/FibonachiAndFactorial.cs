using System; 
using System.Collections.Generic; 
using System.Numerics;


namespace Task4._2
{
    public class FibonachiAndFactorial
    {
        public double Fib(int index)
       { 
             double fib; 
             double d1 = (1 + Math.Sqrt(5)) / 2; 
             double d2 = (1 - Math.Sqrt(5)) / 2; 
             fib = ((Math.Pow(d1, index)) - Math.Pow(d2, index)) / Math.Sqrt(5); 
             return fib; 
         } 
         public BigInteger FactTree(int index)
          { 
             if (index < 0) 
                  return 0; 
             if (index == 0) 
                  return 1; 
             if (index == 1 || index == 2) 
                 return index; 
             return ProdTree(2, index); 
          } 
         static BigInteger ProdTree(int l, int r)
         { 
             if (l > r) 
                 return 1; 
             if (l == r) 
                 return l; 
             if (r - l == 1) 
                 return (BigInteger)l* r; 
             int m = (l + r) / 2; 
             return ProdTree(l, m) * ProdTree(m + 1, r); 
         } 

    }
}
