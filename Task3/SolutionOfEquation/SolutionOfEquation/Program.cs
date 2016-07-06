using System;
using Equation;
using System.IO;
using System.Configuration;


namespace SolutionOfEquation
{
    class Program
    {
         
        static void Main(string[] args)
        {
            
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Chose the type of equation: \n 1.quadratic equation \n 2.linear equation \n 3.multiplicate matrix \n 4.Exit");
                string flag = Console.ReadLine();
                while (!int.TryParse(flag, out choice))
                {
                    Console.WriteLine("incorrect menu item");
                    Console.WriteLine("Chose the type of equation: \n 1.quadratic equation \n 2.linear equation \n 3.multiplicate matrix \n 4.Exit");
                    flag = Console.ReadLine();
                }
               switch (choice)
                {
                    case 1:
                        {
                            var FileStream = File.Create(ResourceData.FilePath);
                            FileStream.Close();
                            File.AppendAllText(ResourceData.FilePath, "quadratic equation");
                            int corA, corB, corC;
                            string a, b, c;
                            WorkWithQuadraticEquation quadr = new WorkWithQuadraticEquation();
                            Console.WriteLine("Enter coefficient a:");
                            a = Console.ReadLine();
                            while (!Int32.TryParse(a, out corA))
                            {
                                Console.WriteLine("Please enter correct a.");
                                File.Create(ResourceData.FilePath);
                                File.AppendAllText(ResourceData.FilePath, "Incorrect coefficient a");
                                a = Console.ReadLine();
                            }

                            Console.WriteLine("Enter coefficient b:");
                            b = Console.ReadLine();
                            while (!Int32.TryParse(b, out corB))
                            {
                                Console.WriteLine("Please enter correct b.");

                                File.AppendAllText(ResourceData.FilePath, "Incorrect coefficient b");
                                b = Console.ReadLine();
                            }

                            Console.WriteLine("Enter coefficient c:");
                            c = Console.ReadLine();
                            while (!Int32.TryParse(c, out corC))
                            {
                                Console.WriteLine("Please enter correct c.");
                                File.AppendAllText(ResourceData.FilePath, "Incorrect coefficient c");
                                c = Console.ReadLine();
                            }

                            File.AppendAllText(ResourceData.FilePath, $"{corA}x^2 + {corB}x + {corC} = 0");
                            Console.WriteLine($"{corA}x^2 + {corB}x + {corC} = 0");
                            quadr.CheckCoefficients(corA, corB, corC);

                            break;
                        }
                    case 2:
                        {
                            int corA, corB;
                            string a, b;
                            File.AppendAllText(ResourceData.FilePath, "linear");
                            WorkWithLinearEquation lin = new WorkWithLinearEquation();
                            Console.WriteLine("Enter coefficient a:");
                            a = Console.ReadLine();
                            while (!Int32.TryParse(a, out corA))
                            {
                                Console.WriteLine("Please enter correct a.");
                                File.AppendAllText(ResourceData.FilePath, "Incorrect coefficient a");
                                a = Console.ReadLine();
                            }

                            Console.WriteLine("Enter coefficient b:");
                            b = Console.ReadLine();
                            while (!Int32.TryParse(b, out corB))
                            {
                                Console.WriteLine("Please enter correct b.");
                                File.AppendAllText(ResourceData.FilePath, "Incorrect coefficient b");
                                b = Console.ReadLine();
                            }

                            File.AppendAllText(ResourceData.FilePath, $"{corA}x + {corB} = 0");
                            lin.CheckCoefficients(corA, corB);

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Matrix multiplication:");
                            WorkWithMatrix matr = new WorkWithMatrix();
                            string[] mass = matr.ReadFromFile(ConfigurationManager.AppSettings["FilePath"]);
                            double[,] firstMatrix = matr.ReadMatrix(mass);
                            mass = matr.GetMatrix(mass);
                            double[,] secondMatrix = matr.ReadMatrix(mass);
                            Console.WriteLine("Matrix Multiplication");
                            double[,] result = matr.MultiplicateMatrix(firstMatrix, secondMatrix);
                            matr.Print(result);
                            break;
                        }
                    case 4: break;
                    default:
                        {
                            Console.WriteLine("Incorrect menu item");
                            break;
                        }
                }
           
            }
            

        }

    }
}
