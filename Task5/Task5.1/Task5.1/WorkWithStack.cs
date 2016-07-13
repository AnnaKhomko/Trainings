using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public class WorkWithStack : ICollection
    {
        public Stack<int> Stack { get; set; }

        public WorkWithStack()
        {
            this.Stack = new Stack<int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.Stack.Push(i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.Stack.Contains(rand.Next(this.Stack.Count));
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.Stack.Count; i++)
            {
                element = this.Stack.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            for (int i = 0; i < count; i++)
                this.Stack.Pop();
        }

        public override string ToString()
        {
            return "Stack";
        }
    }
}
