using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class WorkWithStack : ICollection
    {
        public Stack<string> ChekingStack { get; set; }

        public WorkWithStack()
        {
            this.ChekingStack = new Stack<string>();
        }

        public void AddElements()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 50000; i++)
            {
                this.ChekingStack.Push("HelloWorld");
            }
            stopWatch.Stop();
            Console.WriteLine($" Add to Stack {stopWatch.ElapsedMilliseconds.ToString()}");

        }

        public void FindInList()
        {
            throw new NotImplementedException();
        }

        public void ReadElements()
        {
            string element;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < this.ChekingStack.Count; i++)
            {
                element = this.ChekingStack.ElementAt(i);
            }
            stopWatch.Stop();
            Console.WriteLine($" Read from Stack {stopWatch.ElapsedMilliseconds.ToString()}");
        }

        public void RemoveElements()
        {
            throw new NotImplementedException();
        }
    }
}
