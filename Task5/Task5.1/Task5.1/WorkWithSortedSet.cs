using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class WorkWithSortedSet : ICollection
    {
        public SortedSet<string> ChekingSortedSet { get; set; }

        public WorkWithSortedSet()
        {
            this.ChekingSortedSet = new SortedSet<string>();
        }

        public void AddElements()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 50000; i++)
            {
                this.ChekingSortedSet.Add("HelloWorld");
            }
            stopWatch.Stop();
            Console.WriteLine($" Add to SortedSet {stopWatch.ElapsedMilliseconds.ToString()}");
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
            for (int i = 0; i < this.ChekingSortedSet.Count; i++)
            {
                element = this.ChekingSortedSet.ElementAt(i);
            }
            stopWatch.Stop();
            Console.WriteLine($" Read from SortedSet {stopWatch.ElapsedMilliseconds.ToString()}");
        }

        public void RemoveElements()
        {
            throw new NotImplementedException();
        }
    }
}
