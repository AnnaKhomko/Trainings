using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    public class ConsoleReadWrite
    {
        public void ShowResults(Point p1, Point p2, Point p3)
        {
            Console.WriteLine($"{p1.ToString()} (1st point):");
            Console.WriteLine($"{p2.ToString()} (2nd point):");
            Console.WriteLine($"{p3.ToString()} (3rd point):");
            Console.WriteLine("Are points equals?");
            Console.WriteLine($"Point 1 and Point 2: {p1.Equals(p2).ToString()}.");
            Console.WriteLine($"Point 1 and Point 3: {p1.Equals(p3).ToString()}.");
            Console.WriteLine($"Point 2 and Point 3: {p2.Equals(p3).ToString()}.");
        }
    }
}
