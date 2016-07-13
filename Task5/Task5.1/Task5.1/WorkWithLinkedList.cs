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
        public LinkedList<int> LinkedList { get; set; }

        public WorkWithLinkedList()
        {
            this.LinkedList = new LinkedList<int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.LinkedList.AddFirst(i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            int item = rand.Next(this.LinkedList.Count);
            for (int i = 0; i < count; i++)
                this.LinkedList.Contains(item);
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.LinkedList.Count; i++)
            {
                element = this.LinkedList.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                this.LinkedList.Remove(rand.Next(this.LinkedList.Count));
            }
        }

        public override string ToString()
        {
            return "Linked List";
        }
    }
}
