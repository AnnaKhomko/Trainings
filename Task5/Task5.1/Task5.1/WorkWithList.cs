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
        public List<int> CheckingList { get; set; }

        public WorkWithList()
        {
           this.CheckingList = new List<int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.CheckingList.Add(i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            ;
            for (int i = 0; i < count; i++)
                this.CheckingList.Contains(rand.Next(this.CheckingList.Count));
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.CheckingList.Count; i++)
            {
                element = this.CheckingList.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.CheckingList.Remove(rand.Next(this.CheckingList.Count));
        }

        public override string ToString()
        {
            return "List";
        }
    }
}
