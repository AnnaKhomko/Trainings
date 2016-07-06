using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    public class CheckExceptions
    {
        
        public bool CheckNegativeIndex(int index)
        {
            bool flag;
            if (index < 0)
            {
                flag = false;
            }
            else flag = true;
            return flag;
        }

    }


}
