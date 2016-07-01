using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Equation
{
    public class WorkWithMatrix
    {
        public string[] ReadFromFile(String path)
        {

            string[] mass = File.ReadAllLines(path);
            return mass;
        }

        public int[,] ReadMatrix(string[] mass)
        {
            int n, m;
            n = Convert.ToInt32(mass[0]);
            m = Convert.ToInt32(mass[1]);

            Console.WriteLine(n);
            Console.WriteLine(m);
            int[,] matrix1 = new int[n, m];
            for (int p = 0; p < n; p++)
            {
                int[] matr = mass[p + 2].Split(new char[] { ' ' },
              StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                for (int i = 0; i < matr.Length; i++)
                {
                    matrix1[p, i] = matr[i];
                }
            }
            Console.WriteLine("Матрица:");
            Print(matrix1);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(matrix1[i, j]);
            //    }
            //    Console.WriteLine(" ");
            //}
            return matrix1;
        }


        public string[] GetMatrix(string[] mass)
        {
            int n = Convert.ToInt32(mass[0]);
            List<string> mas = new List<string>();
            mas = mass.ToList();
            mas.RemoveRange(0, n + 2);
            mass = mas.ToArray();
            return mass;
        }
         
        public int[,] MatrixMultiplication(int [,] a, int [,] b )
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("can't miltiplicate matrix");
            int[,] res = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        res[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return res;
        }
       public static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }







    }

    }

