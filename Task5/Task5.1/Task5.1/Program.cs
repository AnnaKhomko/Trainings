using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithList list = new WorkWithList();
            list.AddElements();
            list.ReadElements();

            WorkWithLinkedList linkedList = new WorkWithLinkedList();
            linkedList.AddElements();
            linkedList.ReadElements();

            WorkWithDictionary dictionary = new WorkWithDictionary();
            dictionary.AddElements();
            dictionary.ReadElements();

            WorkWithQueue queue = new WorkWithQueue();
            queue.AddElements();
            queue.ReadElements();

            WorkWithStack stack = new WorkWithStack();
            stack.AddElements();
            stack.ReadElements();

            WorkWithSortedSet sortedSet = new WorkWithSortedSet();
            sortedSet.AddElements();
            sortedSet.ReadElements();

            WorkWithSortedDictionary sortedDictionary = new WorkWithSortedDictionary();
            sortedDictionary.AddElements();
            sortedDictionary.ReadElements();

            Console.ReadLine();

        }
    }
}
