using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Program
    {
        public static Bucket buc = new Bucket();
        public static List<Product> or = new List<Product>();
        static void Main(string[] args)
        {
            ShowMenu();
        }

        public static void ShowMenu()
        {

            int choice = 0;
            while (choice != 4)
            {
                Product product = new Product();
                Console.WriteLine("1. Add product \n2. Delete product \n3. Count total summ \n4.Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            
                            string name;
                            int cost, amount;
                            Console.WriteLine("enter product name");
                            name = Console.ReadLine();
                            Console.WriteLine("enter product cost");
                            cost = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter product amount");
                            amount = int.Parse(Console.ReadLine());
                            product.Name = name;
                            product.Cost = cost;
                            product.Amount = amount;
                            or = buc.AddProduct(product);
                            Console.WriteLine("product was add successfully.");
                            break;
                        }
                    case 2:
                        {
                            int deleteProduct;
                            buc.ShowProducts(or);
                            Console.WriteLine("Enter index of product you want to delete");
                            deleteProduct = int.Parse(Console.ReadLine());
                            or = buc.DeleteProduct(deleteProduct);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Total summ is : {buc.CountSumm()}");
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
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
