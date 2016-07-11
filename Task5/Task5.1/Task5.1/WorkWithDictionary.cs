using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class WorkWithDictionary : ICollection
    {
        public Dictionary<int, int> CheckingDictionary { get; set; }

        public WorkWithDictionary()
        {
            this.CheckingDictionary = new Dictionary<int, int>();
        }

        public void AddElements(int count)
        {
            
            for (int i = 0; i < count; i++)
            {
                this.CheckingDictionary.Add(i, i);
            }
            
        }

        public void ReadElements()
        {
            for (int i = 0; i < this.CheckingDictionary.Count; i++)
            {
                var element = this.CheckingDictionary.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            int key = rand.Next(this.CheckingDictionary.Count);
            for (int i = 0; i < count; i++)
            this.CheckingDictionary.Remove(key);
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.CheckingDictionary.ContainsValue(rand.Next(this.CheckingDictionary.Count));
        }

        public override string ToString()
        {
            return "Dictionary";
        }
    }
}
