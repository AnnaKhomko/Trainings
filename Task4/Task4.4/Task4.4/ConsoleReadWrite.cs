using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    public class ConsoleReadWrite
    {
        Bucket bucket = new Bucket();
        List<Product> products = new List<Product>();

        public void ShowMenu()
        {
            Console.WriteLine("1. Add product \n2. Delete product \n3. Count total summ \n4. Exit\n");
        }

        public void RunMenu()
        {

            int choice = 0;
            while (choice != 4)
            {
                Product product = new Product();
                ShowMenu();
                String flag = Console.ReadLine();
                Checks checks = new Checks();
                choice = checks.CheckInput(flag);
                switch (choice)
                {
                    case 1:
                        {
                            AddProduct(product);
                            break;
                        }
                    case 2:
                        {
                            DeleteProduct(product);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Total summ is : {bucket.CountSumm()}");
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

        public void AddProduct(Product product)
        {

            string name;
            int cost, amount;
            Console.WriteLine("Enter product name");
            name = Console.ReadLine();
            Console.WriteLine("Enter product cost");
            string uncheckedCost = Console.ReadLine();
            Checks checks = new Checks();
            cost = checks.CheckInput(uncheckedCost);
            Console.WriteLine("Enter product amount");
            string uncheckedAmount = Console.ReadLine();
            amount = checks.CheckInput(uncheckedAmount);
            product.Name = name;
            product.Cost = cost;
            product.Amount = amount;
            products = bucket.AddProduct(product);
            Console.WriteLine("Product was add successfully.");
        }

        public void DeleteProduct(Product product)
        {
            int deleteProduct;
            bucket.ShowProducts(products);
            Console.WriteLine("Enter index of product you want to delete");
            string uncheckedIndex = Console.ReadLine();
            Checks checks = new Checks();
            deleteProduct = checks.CheckInput(uncheckedIndex);
            deleteProduct = int.Parse(Console.ReadLine());
            products = bucket.DeleteProduct(deleteProduct);
            Console.WriteLine("Product was deleted successfully ");
        }
    }
}
