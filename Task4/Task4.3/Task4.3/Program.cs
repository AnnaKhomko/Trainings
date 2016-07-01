using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                MyClass mc = new MyClass();
            }
            Console.WriteLine($"Object was created for: {MyClass.count} times");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
