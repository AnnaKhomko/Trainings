using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    public class Bucket
    {
        private List<Product> order = new List<Product>();

        public List<Product> AddProduct(Product pr)
        {
            order.Add(pr);
            return order;
        }

       public List<Product> DeleteProduct(int index)
        {
            order.RemoveAt(index);
            return order;
        }

        public int CountSumm()
        {
            int totalSumm = 0;

            foreach (var pr in order)

                totalSumm = totalSumm + pr.Cost * pr.Amount;
            
            return totalSumm;
        }

        public void ShowProducts(List <Product> order)
        {
            int i = -1;
            Console.WriteLine("List of your products:\n");
            foreach (var pr in order)
            {
                Console.WriteLine( ++i + ") " + pr.ToString());
            }
        }

       
    }
}
