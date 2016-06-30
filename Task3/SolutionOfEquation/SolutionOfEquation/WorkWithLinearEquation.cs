using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfEquation
{
    class WorkWithLinearEquation
    {
        int a, b, c;
        public WorkWithLinearEquation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void CheckCoefficients(int a, int b, int c)
        {
            
            List<int> roots = new List<int>();
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("root of the equation is any number");
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("there are no roots of the equation");
            }
            else if ((a == 0 && c == 0) || (b == 0 && c == 0))
            {
                Console.WriteLine("the root is: " + 0);
            }
            else if (a == 0)
            {

            }
            else
            {
                int discriminant = FindDiscriminant(a, b, c);
                int flag = CheckDiscriminant(discriminant);
                if (flag == 1)
                {
                    Console.WriteLine("there are no roots of the equation");
                }
                else if (flag == 2)
                {
                    Console.WriteLine("Discriminant = 0 , solution have 1 root");
                    roots.Add(FindSpecialRoot(a, b));

                }
            }
        }
        public int FindDiscriminant(int a, int b, int c)
        {
            int discriminant = b * b - 4 * a * c;
            return discriminant;
        }

        public int CheckDiscriminant(int discriminant)
        {
            int flag;
            List<int> roots = new List<int>();
            if (discriminant < 0)
            {
                flag = 1;
            }
            else if (discriminant == 0)
            {
                flag = 2;
            }
            else
            {
                flag = 3;
            }
            return flag;
        }

        public int FindSpecialRoot(int a, int b)
        {
            int root = b * (-1) / (2 * a);
            return root;
        }

        public int FindRoots(int a, int b)
        {
            int root = b * (-1) / (2 * a);
            return root;
        }
    }
}
