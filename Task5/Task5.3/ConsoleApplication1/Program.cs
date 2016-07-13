using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5._3;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithLINQToXML w = new WorkWithLINQToXML();
            w.GetListOfOrders();
            w.CountStatisticsByDate();
            //w.TotalSumOfOrdersMoreThanX(1020); 
            //w.GroupByCountry();
            //w.SumOfOrders(110277.32);
            //Console.WriteLine();
            //w.SumOfOrderMoreThan(20);
            //Console.WriteLine();
            //w.DateOfFirstOrder();
            //Console.WriteLine();
            //w.OrderListOfDate();
            //Console.WriteLine();
            //w.ClientsWithInvalidData();
            Console.ReadLine();
            
        }
    }
}
