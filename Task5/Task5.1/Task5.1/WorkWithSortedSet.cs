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
        public SortedSet<int> ChekingSortedSet { get; set; }

        public WorkWithSortedSet()
        {
            this.ChekingSortedSet = new SortedSet<int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.ChekingSortedSet.Add(i);
            }
        } 

        public void FindElement(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.ChekingSortedSet.Contains(rand.Next(this.ChekingSortedSet.Count));
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.ChekingSortedSet.Count; i++)
            {
                element = this.ChekingSortedSet.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.ChekingSortedSet.Remove(rand.Next(this.ChekingSortedSet.Count));
        }

        public override string ToString()
        {
            return "Sorted Set";
        }
    }
}
