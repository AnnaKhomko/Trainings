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
        public SortedDictionary<int, int> SortedDictionary { get; set; }

        public WorkWithSortedDictionary()
        {
            this.SortedDictionary = new SortedDictionary<int, int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.SortedDictionary.Add(i, i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.SortedDictionary.ContainsValue(rand.Next(this.SortedDictionary.Count));
        }

        public void ReadElements()
        {
            for (int i = 0; i < this.SortedDictionary.Count; i++)
            {
               var  element = this.SortedDictionary.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            int key = rand.Next(int.Parse(ResourceData.CountForAdd));
            for (int i = 0; i < count; i++)
                this.SortedDictionary.Remove(rand.Next(this.SortedDictionary.Count));
        }

        public override string ToString()
        {
            return "Sorted Dictionary";
        }
    }
}
