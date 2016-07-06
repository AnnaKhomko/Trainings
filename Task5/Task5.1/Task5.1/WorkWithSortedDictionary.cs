using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class WorkWithSortedDictionary : ICollection
    {
        public SortedDictionary<int, string> CheckingSortedDictionary { get; set; }

        public WorkWithSortedDictionary()
        {
            this.CheckingSortedDictionary = new SortedDictionary<int, string>();
        }

        public void AddElements()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 50000; i++)
            {
                this.CheckingSortedDictionary.Add(i, "HelloWorld");
            }
            stopWatch.Stop();
            Console.WriteLine($" Add to SotredDictionary {stopWatch.ElapsedMilliseconds.ToString()}");
        }

        public void FindInList()
        {
            throw new NotImplementedException();
        }

        public void ReadElements()
        {
           
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < this.CheckingSortedDictionary.Count; i++)
            {
               var  element = this.CheckingSortedDictionary.ElementAt(i);
            }
            stopWatch.Stop();
            Console.WriteLine($" Read from SortedDictionary {stopWatch.ElapsedMilliseconds.ToString()}");
        }

        public void RemoveElements()
        {
            throw new NotImplementedException();
        }
    }
}
