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
        public LinkedList<int> CheckingLinkedList { get; set; }

        public WorkWithLinkedList()
        {
            this.CheckingLinkedList = new LinkedList<int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.CheckingLinkedList.AddFirst(i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            int item = rand.Next(this.CheckingLinkedList.Count);
            for (int i = 0; i < count; i++)
                this.CheckingLinkedList.Contains(item);
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.CheckingLinkedList.Count; i++)
            {
                element = this.CheckingLinkedList.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                this.CheckingLinkedList.Remove(rand.Next(this.CheckingLinkedList.Count));
            }
        }

        public override string ToString()
        {
            return "Linked List";
        }
    }
}
