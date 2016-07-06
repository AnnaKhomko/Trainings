using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3
{
    public class Run
    {
        public void ShowResult()
        {
            for (int i = 0; i < 10; i++)
            {
                MyClass mc = new MyClass();
            }
            Console.WriteLine($"Object was created for: {MyClass.count} times");
        }
    }
}
