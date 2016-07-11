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
        public Stack<int> ChekingStack { get; set; }

        public WorkWithStack()
        {
            this.ChekingStack = new Stack<int>();
        }

        public void AddElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.ChekingStack.Push(i);
            }
        }

        public void FindElement(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
                this.ChekingStack.Contains(rand.Next(this.ChekingStack.Count));
        }

        public void ReadElements()
        {
            int element;
            for (int i = 0; i < this.ChekingStack.Count; i++)
            {
                element = this.ChekingStack.ElementAt(i);
            }
        }

        public void RemoveElements(int count)
        {
            for (int i = 0; i < count; i++)
                this.ChekingStack.Pop();
        }

        public override string ToString()
        {
            return "Stack";
        }
    }
}
