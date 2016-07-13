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
        public SortedSet<int> SortedSet { get; set; }

        public WorkWithSortedSet()
        {
            this.SortedSet = new SortedSet<int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.SortedSet.Add(i);
            }
        } 

        public void FindElement(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.SortedSet.Contains(rand.Next(this.SortedSet.Count));
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.SortedSet.Count; i++)
            {
                element = this.SortedSet.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.SortedSet.Remove(rand.Next(this.SortedSet.Count));
        }

        public override string ToString()
        {
            return "Sorted Set";
        }
    }
}
