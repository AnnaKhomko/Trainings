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
        public Queue<int> Queue { get; set; }

        public WorkWithQueue()
        {
            this.Queue = new Queue<int>();
        }
        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.Queue.Enqueue(i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            ;
            for (int i = 0; i < count; i++)
                this.Queue.Contains(rand.Next(this.Queue.Count));
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.Queue.Count; i++)
            {
                element = this.Queue.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < this.Queue.Count; i++)
                this.Queue.Dequeue();
        }

        public override string ToString()
        {
            return "Queue";
        }
    }
}
