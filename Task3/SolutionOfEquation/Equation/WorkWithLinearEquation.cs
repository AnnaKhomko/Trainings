using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    public class WorkWithLinearEquation
    {
        int a, b;
        int root;
        
        public int CheckCoefficients(int a, int b)
        {

            if (a == 0 && b == 0)
            {
                File.AppendAllText(ResourceData.FilePath, "root of the equation is any number");
                Console.WriteLine("root of the equation is any number");
            }
            else if (a == 0)
            {
                File.AppendAllText(ResourceData.FilePath, "there are no roots of the equation");
                Console.WriteLine("there are no roots of the equation");
            }
            else if (b == 0)
            {
                File.AppendAllText(ResourceData.FilePath, "root is 0");
                Console.WriteLine("root is 0");
            }

            else
            {
                root = FindRoot(a, b);
                File.AppendAllText(ResourceData.FilePath, Convert.ToString(root));
            }
            return root;
        }
        
        public int FindRoot(int a, int b)
        {
            int root = b * (-1)/a;
            return root;
        }
    }
}
