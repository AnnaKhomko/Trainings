using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class WorkWithDictionary : ICollection
    {
        public Dictionary<int, string> CheckingDictionary { get; set; }

        public WorkWithDictionary()
        {
            this.CheckingDictionary = new Dictionary<int, string>();
        }

        public void AddElements()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 50000; i++)
            {
                this.CheckingDictionary.Add(i, "HelloWorld");
            }
            stopWatch.Stop();
            Console.WriteLine($" Add to Dictionary {stopWatch.ElapsedMilliseconds.ToString()}");
        }

        public void FindInList()
        {
            throw new NotImplementedException();
        }

        public void ReadElements()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < this.CheckingDictionary.Count; i++)
            {
                var element = this.CheckingDictionary.ElementAt(i);
            }
            stopWatch.Stop();
            Console.WriteLine($" Read from Dictionary {stopWatch.ElapsedMilliseconds.ToString()}");
        }

        public void RemoveElements()
        {
            throw new NotImplementedException();
        }
    }
}
