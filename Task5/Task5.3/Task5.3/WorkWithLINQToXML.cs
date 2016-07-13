using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task5._3
{
    public class WorkWithLINQToXML
    {
       
        public XDocument Doc { get; set; }
        public List<XElement> listOfOrders;
        
        public WorkWithLINQToXML()
        {
            listOfOrders = new List<XElement>();
            Doc = XDocument.Load(ResourceData.PathToXMLFile);

        }

        //2.Сгруппировать клиентов по странам.

        public Dictionary<string, int> GroupByCountry()
        {

            var groupByCountry = Doc.Root
                .Elements("customer")
                .GroupBy(el => el.Element("country").Value).ToDictionary(
                k => k.Key,
                v => v.ToList().Count
                );
            return groupByCountry;
        }



        //1. Выдайте список всех клиентов, чей суммарный оборот(сумма всех заказов) 
        // превосходит некоторую величину X.Продемонстрируйте выполнение запроса с 
        // различными X (подумайте, можно ли обойтись без копирования 
        // запроса несколько раз)

        public Dictionary<string, decimal> TotalSumOfOrdersMoreThanX(decimal x)
        {
            var totalSumOfOrdersMoreThanX = Doc.Root.Elements("customer")
                .Select(l => new
                {
                    name = l.Element("name").Value,
                    listOfTotal = l.Element("orders")
                .Elements("order")
                .Select(n => decimal.Parse(n.Element("total").Value))
                .ToList()
                })
                .Where(count => count.listOfTotal.Count > 0)
                .ToDictionary(s => s.name, n => n.listOfTotal.Sum())
                .Where(n => n.Value > x)
                .ToDictionary(k => k.Key, k => k.Value);

            return totalSumOfOrdersMoreThanX;
        }

        //3 Найдите всех клиентов, у которых были заказы, 
        //превосходящие по сумме величину X

        public Dictionary<string, decimal> SumOfOrderMoreThanX(decimal x)
        {
            var sumOfOrderMoreThanX = Doc.Root.Elements("customer")
                .Select(l => new
                {
                    name = l.Element("name").Value,
                    listOfTotal = l.Element("orders")
                .Elements("order")
                .Select(n => Decimal.Parse(n.Element("total").Value))
                .ToList()
                })
                .Where(count => count.listOfTotal.Count > 0)
                .ToDictionary(s => s.name, n => n.listOfTotal.Max())
                .Where(n => n.Value > x)
                .ToDictionary(k => k.Key,  v => v.Value);

            return sumOfOrderMoreThanX;
        }

        //Выдайте список клиентов с указанием, начиная с какого месяца какого года
        //они стали клиентами(принять за таковые месяц и год самого первого заказа)

        public Dictionary<string,string> DateOfFirstOrder()
        {
            var dateOfFirstOrder = Doc.Root.Elements("customer")
                .Select(s => new
                {
                    name = s.Element("name").Value,
                    listOfDates = s.Element("orders")
                .Elements("order")
                .Select(p => DateTime.Parse(p.Element("orderdate").Value).ToString("yyyy.MM"))
                .ToList()
                }).Where(t => t.listOfDates.Count > 0)
                .ToDictionary(t => t.name, t => t.listOfDates.First());

            return dateOfFirstOrder;
        }

        //Сделайте предыдущее задание, но выдайте список отсортированным 
        //по году, месяцу, оборотам клиента(от максимального к минимальному)
        //и имени клиента

        public void OrderedListOfDateOfFirstOrder()
        {
            var resultList = Doc.Root.Elements("customer")
                .Where(n => n.Element("orders")
                .Elements("order").Count() >= 1)
                .Select(n => new
                {

                    name = n.Element("name").Value,
                    ListOfTotall = n.Element("orders")
                     .Elements("order")
                     .Select(g => Decimal.Parse(g.Element("total").Value)).Sum(),
                    date = n.Element("orders")
                    .Elements("order")
                    .Select(g => DateTime.Parse(g.Element("orderdate").Value))
                    .ToList().First().ToString("yyyy.MM")


                }).ToArray();

        }

        // Укажите всех клиентов, у которых указан нецифровой код или 
        // не заполнен регион или в телефоне не указан код оператора
        //(для простоты считаем, что это равнозначно «нет круглых скобочек в начале»).

        public int ClientsWithInvalidData()
        {
            int code;
            int count  = Doc.Root.Elements("customer")
                .Where(e => e.Element("postalcode") == null || int.TryParse(e.Element("postalcode").Value, out code) == false
                || e.Element("region") == null 
                || e.Element("phone").Value == null 
                || e.Element("phone").Value.ToString().Trim()[0] != '(').ToList().Count;

            return count;
        }


        public void GetListOfOrders()
        {
            var listOfCustomers = Doc.Root.Elements("customer").ToList();
            foreach (var c in listOfCustomers)
            {
                this.listOfOrders.AddRange(c.Element("orders").Elements("order").ToList());
            }
        }



        public Dictionary<string,decimal> CountAverageProfit()
        {
            var averageProfit = Doc.Root
                .Elements("customer").GroupBy(n => n.Element("city").Value).ToDictionary(
                    g => g.Key,
                    g =>Math.Round( g
                    .Sum(n => n.Element("orders")
                     .Elements("order")
                     .Sum(k => Decimal.Parse(k.Element("total").Value))) / g.Sum(n => n.Element("orders")
                     .Elements("order").Count()),2));

                     return averageProfit;

        }

        public Dictionary <string, decimal> CountAverageIntensity()
        {

            var averageIntensity = Doc.Root
                .Elements("customer").GroupBy(n => n.Element("city").Value).ToDictionary(
                    g => g.Key,
                    g => (Decimal)g
                    .Sum(n => n.Element("orders")
                    .Elements("order").Count()) / (Decimal)g.Count());

            return averageIntensity;

        }


        //8. Сделайте среднегодовую статистику активности клиентов по месяцам(без учета года), статистику по годам, по
        //   годам и месяцам(т.е.когда один месяц в разные годы имеет своё значение).


        public Dictionary<int,int> CountStatisticsByMonths()
        {
            var statisticsByMonths = listOfOrders.GroupBy(data => Convert.ToDateTime(data.Element("orderdate").Value).Month)
                .OrderBy(g => g.Key)
                .ToDictionary(
                    g => g.Key,
                    g => g.ToList().Count()
                );
            return statisticsByMonths;
        }


        public Dictionary<int, int> CountStatisticsByYears()
        {
            var statisticsByYears = listOfOrders.GroupBy(data => Convert.ToDateTime(data.Element("orderdate").Value).Year)
                .OrderBy(g => g.Key)
                .ToDictionary(
                    g => g.Key,
                    g => g.ToList().Count()
                );
            return statisticsByYears;
        }


        public Dictionary<string,int> CountStatisticsByDate()
        {
            var statisticsByDate = listOfOrders.GroupBy(data => DateTime.Parse(data.Element("orderdate").Value).ToString("yyyy.MM"))
                .OrderBy(g => g.Key)
                .ToDictionary(
                    g => g.Key,
                    g => g.ToList().Count()
                );
            return statisticsByDate;
        }

    }
}

