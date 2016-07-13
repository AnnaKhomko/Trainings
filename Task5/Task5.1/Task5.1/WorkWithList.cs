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
        public List<int> List { get; set; }

        public WorkWithList()
        {
           this.List = new List<int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.List.Add(i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            ;
            for (int i = 0; i < count; i++)
                this.List.Contains(rand.Next(this.List.Count));
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.List.Count; i++)
            {
                element = this.List.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.List.Remove(rand.Next(this.List.Count));
        }

        public override string ToString()
        {
            return "List";
        }
    }
}
