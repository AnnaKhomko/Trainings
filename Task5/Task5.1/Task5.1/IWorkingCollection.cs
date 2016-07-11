using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    public interface ICollection
    {
        void AddElements(int count);
        void ReadElements();
        void FindElement(int count);
        void RemoveElements(int count);

    }
}
