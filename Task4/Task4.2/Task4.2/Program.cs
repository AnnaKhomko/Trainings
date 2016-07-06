using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite readWrite = new ReadWrite();
            Console.WriteLine("Work with fibonachi");
            readWrite.ReadIndexForFibonachi();
            Console.WriteLine("Work with factorial");
            readWrite.ReadIndexForFactorial();
            Console.ReadLine();
        }
    }
}
