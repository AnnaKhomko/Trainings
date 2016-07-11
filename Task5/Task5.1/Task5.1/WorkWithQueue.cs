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
        public Queue<int> CheckingQueue { get; set; }

        public WorkWithQueue()
        {
            this.CheckingQueue = new Queue<int>();
        }
        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.CheckingQueue.Enqueue(i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            ;
            for (int i = 0; i < count; i++)
                this.CheckingQueue.Contains(rand.Next(this.CheckingQueue.Count));
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.CheckingQueue.Count; i++)
            {
                element = this.CheckingQueue.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < this.CheckingQueue.Count; i++)
                this.CheckingQueue.Dequeue();
        }

        public override string ToString()
        {
            return "Queue";
        }
    }
}
