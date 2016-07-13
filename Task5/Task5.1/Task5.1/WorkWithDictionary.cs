using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Task5._1
{
    public class WorkWithDictionary : ICollection
    {
        public Dictionary<int, int> Dictionary { get; set; }

        public WorkWithDictionary()
        {
            this.Dictionary = new Dictionary<int, int>();
        }

        public void AddElements(int count)
        {
            
            for (int i = 0; i < count; i++)
            {
                this.Dictionary.Add(i, i);
            }
            
        }

        public void ReadElements()
        {
            for (int i = 0; i < this.Dictionary.Count; i++)
            {
                var element = this.Dictionary.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            Random rand = new Random();
            int key = rand.Next(this.Dictionary.Count);
            for (int i = 0; i < count; i++)
            this.Dictionary.Remove(key);
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.Dictionary.ContainsValue(rand.Next(this.Dictionary.Count));
        }

        public override string ToString()
        {
            return "Dictionary";
        }
    }
}
