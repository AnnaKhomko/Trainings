using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._5
{
    public class ReadWrite
    {
        public Rectangle CreateRectangle()
        {
            CheckSides check = new CheckSides();
            string uncheckedLength, uncheckedWidth;
            int length, width;
            do
            {
                Console.WriteLine("Enter length");
                uncheckedLength = Console.ReadLine();
                length = check.CheckInput(uncheckedLength);
                Console.WriteLine("Enter width");
                uncheckedWidth = Console.ReadLine();
                width = check.CheckInput(uncheckedLength);
            }
            while (!check.CheckForNegativity(length, width));
            
            Rectangle bigRectangle = new Rectangle(length, width);
            return bigRectangle;
        }

        public void WriteCount()
        {
            Console.WriteLine("Enter big rectangle sides:\n");
            Rectangle bigRectangle = CreateRectangle();
            Console.WriteLine("Enter small rectangle sides:\n");
            Rectangle smallRectangle = CreateRectangle();
            Check check = new Check();
            int count = check.TotalAmount(bigRectangle, smallRectangle);
            Console.WriteLine(count);
        }


    }
}
