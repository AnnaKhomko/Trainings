using System;
using Equation;

namespace SolutionOfEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Chose the type of equation: \n 1.quadratic equation \n 2.linear equation");
            choice = Int32.Parse(Console.ReadLine());
            if (choice == 1)
            {
                WorkWithQuadraticEquation quadr = new WorkWithQuadraticEquation();
                Console.WriteLine("Enter coefficients (a,b,c)");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                int c = Int32.Parse(Console.ReadLine());
                quadr.CheckCoefficients(a, b, c);

            }
            else if (choice == 2)
            {
                WorkWithLinearEquation lin = new WorkWithLinearEquation();
                Console.WriteLine("Enter coefficients (a,b)");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                lin.CheckCoefficients(a, b);
            }
            else
                Console.WriteLine("Enter correct numbers");



            WorkWithMatrix matr = new WorkWithMatrix();
            string [] mass = matr.ReadFromFile(ResourceData.Path);
            int[,] firstMatrix = matr.ReadMatrix(mass);
            mass = matr.GetMatrix(mass);
            int[,] secondMatrix = matr.ReadMatrix(mass);
            int[,] result = matr.MatrixMultiplication(firstMatrix, secondMatrix);
            WorkWithMatrix.Print(result);
                Console.ReadLine();

        }

    }
}
