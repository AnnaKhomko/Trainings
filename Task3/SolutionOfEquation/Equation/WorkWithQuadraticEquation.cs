using System;
using System.Collections.Generic;
using System.IO;

namespace Equation
{
    public class WorkWithQuadraticEquation
    {
      
        List<int> roots = new List<int>();
        WorkWithLinearEquation lin = new WorkWithLinearEquation();
        
        public List<int> CheckCoefficients(int a, int b, int c)
        {

            if (a == 0 && b == 0 && c == 0)
            {
                File.AppendAllText(ResourceData.FilePath, "root of the equation is any number");
                Console.WriteLine("root of the equation is any number");
            }
            else if (a == 0 && b == 0)
            {
                File.AppendAllText(ResourceData.FilePath, "there are no roots of the equation");
                Console.WriteLine("there are no roots of the equation");
            }
            else if ((a == 0 && c == 0) || (b == 0 && c == 0))
            {
                File.AppendAllText(ResourceData.FilePath, "the root is: " + 0);
                Console.WriteLine("the root is: " + 0);
            }
            else if (a == 0)
            {
                lin.CheckCoefficients(b, c);
            }
            else
            {
                int discriminant = FindDiscriminant(a, b, c);
                int flag = CheckDiscriminant(discriminant);
                if (flag == 1)
                {
                    File.AppendAllText(ResourceData.FilePath, "there are no roots of the equation");
                    Console.WriteLine("there are no roots of the equation");
                }
                else if (flag == 2)
                {
                    Console.WriteLine("Discriminant = 0 , solution have 1 root");
                    roots.Add(FindSpecialRoot(a, b));

                }
                else
                {
                    
                    roots = FindRoots(a, b, discriminant);
                }
            }
            return roots;
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
            File.AppendAllText(ResourceData.FilePath, Convert.ToString(root));
            return root;
        }

        public List<int> FindRoots(int a, int b, int discriminant)
        {
            List<int> roots = new List<int>();
            int root1 = (int)(b * (-1) - Math.Sqrt(Convert.ToDouble(discriminant))) / (2 * a);
            File.AppendAllText(ResourceData.FilePath, Convert.ToString(root1));
            roots.Add(root1);
            int root2 = (int)(b * (-1) + Math.Sqrt(Convert.ToDouble(discriminant))) / (2 * a);
            File.AppendAllText(ResourceData.FilePath, Convert.ToString(root2));
            roots.Add(root2);
            return roots;
        }
    }
}
