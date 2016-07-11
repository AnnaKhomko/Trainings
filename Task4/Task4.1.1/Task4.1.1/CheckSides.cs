using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._5
{
    public class CheckSides
    {
        public int CheckInput(string uncheckedString)
        {
            int checkedString;
            while (!int.TryParse(uncheckedString, out checkedString))
            {
                Console.WriteLine("Incorrect type, try again");
                uncheckedString = Console.ReadLine();
            }
            return checkedString;
        }

        public bool CheckForNegativity(int length, int width)
        {
            bool flag;
            if (length <= 0 || width <= 0)
                flag = false;
            else flag = true;
            return flag;
        }
    }
}
