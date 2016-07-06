using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class WorkWithQueue : ICollection
    {
        public Queue<string> CheckingQueue { get; set; }

        public WorkWithQueue()
        {
            this.CheckingQueue = new Queue<string>();
        }
        public void AddElements()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 50000; i++)
            {
                this.CheckingQueue.Enqueue("HelloWorld");
            }
            stopWatch.Stop();
            Console.WriteLine($" Add to Queue {stopWatch.ElapsedMilliseconds.ToString()}");
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
            for (int i = 0; i < this.CheckingQueue.Count; i++)
            {
                element = this.CheckingQueue.ElementAt(i);
            }
            stopWatch.Stop();
            Console.WriteLine($" Read from Queue {stopWatch.ElapsedMilliseconds.ToString()}");
        }

        public void RemoveElements()
        {
            throw new NotImplementedException();
        }
    }
}
