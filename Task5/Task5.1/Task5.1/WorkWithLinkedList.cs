using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class WorkWithLinkedList : ICollection
    {
        public LinkedList<String> CheckingLinkedList { get; set; }

        public WorkWithLinkedList()
        {
            this.CheckingLinkedList = new LinkedList<string>();
        }

        public void AddElements()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 50000; i++)
            {
                this.CheckingLinkedList.AddFirst("HelloWorld");
            }
            stopWatch.Stop();
            Console.WriteLine($" Add to LinkedList {stopWatch.ElapsedMilliseconds.ToString()}");
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
            for (int i = 0; i < this.CheckingLinkedList.Count; i++)
            {
                element = this.CheckingLinkedList.ElementAt(i);
            }
            stopWatch.Stop();
            Console.WriteLine($" Read from LinkedList {stopWatch.ElapsedMilliseconds.ToString()}");
        }

        public void RemoveElements()
        {
            throw new NotImplementedException();
        }
    }
}
