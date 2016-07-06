using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class WorkWithList : ICollection
    {
        public List<String> CheckingList { get; set; }

        public WorkWithList()
        {
           this.CheckingList = new List<string>();
        }

        public void AddElements()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 50000; i++)
            {
                this.CheckingList.Add("HelloWorld");
            }
            stopWatch.Stop();
            Console.WriteLine($" Add to List {stopWatch.ElapsedMilliseconds.ToString()}");
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
            for (int i = 0; i < this.CheckingList.Count; i++)
            {
                element = this.CheckingList.ElementAt(i);
            }
            stopWatch.Stop();
            Console.WriteLine($" Read from List {stopWatch.ElapsedMilliseconds.ToString()}");
        }

        public void RemoveElements()
        {
            throw new NotImplementedException();
        }
    }
}
