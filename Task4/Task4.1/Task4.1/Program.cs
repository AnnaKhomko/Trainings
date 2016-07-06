using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with points.");
            ConsoleReadWrite readWrite = new ConsoleReadWrite();
            Point p1 = new Point(3, 10);
            Point p2 = new Point(7, 10);
            Point p3 = new Point(3, 10);
            readWrite.ShowResults(p1, p2, p3);
            Console.ReadLine();

        }
    }
}
