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
        public SortedDictionary<int, int> CheckingSortedDictionary { get; set; }

        public WorkWithSortedDictionary()
        {
            this.CheckingSortedDictionary = new SortedDictionary<int, int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.CheckingSortedDictionary.Add(i, i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.CheckingSortedDictionary.ContainsValue(rand.Next(this.CheckingSortedDictionary.Count));
        }

        public void ReadElements()
        {
            for (int i = 0; i < this.CheckingSortedDictionary.Count; i++)
            {
               var  element = this.CheckingSortedDictionary.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            int key = rand.Next(int.Parse(ResourceData.CountForAdd));
            for (int i = 0; i < count; i++)
                this.CheckingSortedDictionary.Remove(rand.Next(this.CheckingSortedDictionary.Count));
        }

        public override string ToString()
        {
            return "Sorted Dictionary";
        }
    }
}
