using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    public class Checks
    {
        public int CheckInput(string uncheckedString)
        {
            int checkedString;
            ConsoleReadWrite readWrite = new ConsoleReadWrite();
            while (!int.TryParse(uncheckedString, out checkedString))
            {
                Console.WriteLine("Incorrect type, try again");
                readWrite.ShowMenu();
                uncheckedString = Console.ReadLine();
            }
            return checkedString;
        }
    }
}
