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

        public double[,] ReadMatrix(string[] mass)
        {
            int n, m;
            n = Convert.ToInt32(mass[0]);
            m = Convert.ToInt32(mass[1]);

            Console.WriteLine(n);
            Console.WriteLine(m);
            double[,] matrix1 = new double[n, m];
            for (int p = 0; p < n; p++)
            {
                double[] matr = mass[p + 2].Split(new char[] { ' ' },
              StringSplitOptions.RemoveEmptyEntries).Select(s => Double.Parse(s)).ToArray();
                for (int i = 0; i < matr.Length; i++)
                {
                    matrix1[p, i] = matr[i];
                }
            }
            Console.WriteLine("Matrix:");
            Print(matrix1);

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

        public double[,] MultiplicateMatrix(double[,] a, double[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) Console.WriteLine("can't miltiplicate matrix");
            double[,] res = new double[a.GetLength(0), b.GetLength(1)];
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
        public void Print(double[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j].ToString("0.00"));
                }
                Console.WriteLine();
            }
        }
    }
}

