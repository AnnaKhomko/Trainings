using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5._3;
using System.Xml.Linq;

namespace MsTestsForLINQToXML
{
    [TestClass]
    public class UnitTests
    {
        [TestClass]
        public class TestsForCustomerXML
        {

            WorkWithLINQToXML workWithLINQToXML ;

            [TestInitialize]
            public void Initialize()
            {
                workWithLINQToXML = new WorkWithLINQToXML();

            }


            // 1.Выдайте список всех клиентов, чей суммарный оборот (сумма всех заказов) превосходит некоторую величину X. 
            // Продемонстрируйте выполнение запроса с различными X(подумайте, можно ли обойтись без копирования запроса несколько раз)

            [TestMethod]
            public void TestForTotalSumOfOrdersMoreThanX()
            {
                int firstCount = workWithLINQToXML.TotalSumOfOrdersMoreThanX(1039).Count;
                int secondCount = workWithLINQToXML.TotalSumOfOrdersMoreThanX(1040).Count;
                Assert.AreEqual(1, firstCount - secondCount);
            }


            // 2.	Сгруппировать клиентов по странам.

            [TestMethod]
            public void TestForGroupByCountry()
            {
                var firstList = workWithLINQToXML.GroupByCountry();
                workWithLINQToXML.Doc.Element("customers").FirstNode.NextNode.Remove();
                var secondList = workWithLINQToXML.GroupByCountry();
                int firstCount, secondCount;
                firstList.TryGetValue("Mexico", out firstCount);
                secondList.TryGetValue("Mexico", out secondCount);
                Assert.AreEqual(1, firstCount - secondCount);
            }


            //3.Найдите всех клиентов, у которых были заказы, превосходящие по сумме величину X

            [TestMethod]
            public void TestForSumOfOrderMoreThanX()
            {
                int firstCount = workWithLINQToXML.SumOfOrderMoreThanX(1700).Count;
                int secondCount = workWithLINQToXML.SumOfOrderMoreThanX(1701).Count;
                Assert.AreEqual(1, firstCount - secondCount);

            }


            //4.	Выдайте список клиентов с указанием, начиная с какого месяца какого года они стали клиентами (принять за 
            // таковые месяц и год самого первого заказа)

            [TestMethod]
            public void TestForDateOfFirstOrder()
            {
                var firstList = workWithLINQToXML.DateOfFirstOrder();
                string firstValue;
                firstList.TryGetValue("Wolski  Zajazd", out firstValue);
                Assert.AreEqual("1996.12", firstValue);

            }


            //5.	Сделайте предыдущее задание, но выдайте список отсортированным по году, месяцу, оборотам клиента(от
            //    максимального к минимальному) и имени клиента



            //6.	Укажите всех клиентов, у которых указан нецифровой код или не заполнен регион или в телефоне не указан код
            //    оператора(для простоты считаем, что это равнозначно «нет круглых скобочек в начале»).

            [TestMethod]
            public void TestForClientsWithInvalidData()
            {
                int firstCount = workWithLINQToXML.ClientsWithInvalidData();
                workWithLINQToXML.Doc.Element("customers").FirstNode.Remove();

                int secondCount = workWithLINQToXML.ClientsWithInvalidData();

                Assert.AreEqual(1, firstCount - secondCount);
            }

            //7.	Рассчитайте среднюю прибыльность каждого города(среднюю сумму заказа по всем клиентам из данного города) и
            //  среднюю интенсивность(среднее количество заказов, приходящееся на клиента из каждого города)

            [TestMethod]
            public void TestForCountAverageProfit()
            {
                decimal firstCount, secondCount;
                workWithLINQToXML.CountAverageProfit().TryGetValue("México D.F.", out firstCount);
                workWithLINQToXML.Doc.Element("customers").FirstNode.NextNode.Remove();

                workWithLINQToXML.CountAverageProfit().TryGetValue("México D.F.", out secondCount);

                Assert.AreEqual(-81.91M, firstCount - secondCount);
            }

            [TestMethod]
            public void TestForCountAverageIntensity()
            {
                decimal firstCount, secondCount;
                workWithLINQToXML.CountAverageIntensity().TryGetValue("México D.F.", out firstCount);
                workWithLINQToXML.Doc.Element("customers").FirstNode.NextNode.Remove();

                workWithLINQToXML.CountAverageIntensity().TryGetValue("México D.F.", out secondCount);

                Assert.AreEqual(-0.4M, firstCount - secondCount);
            }

            //8.	Сделайте среднегодовую статистику активности клиентов по месяцам(без учета года), статистику по годам, по
            //   годам и месяцам(т.е.когда один месяц в разные годы имеет своё значение).


            [TestMethod]
            public void TestForCountStatisticsByMonths()
            {
                int firstCount, secondCount;
                workWithLINQToXML.GetListOfOrders();
                workWithLINQToXML.CountStatisticsByMonths().TryGetValue(8, out firstCount);

                WorkWithLINQToXML secondWorkWithLINQToXML = new WorkWithLINQToXML();

                secondWorkWithLINQToXML.Doc.Element("customers").FirstNode.Remove();
                secondWorkWithLINQToXML.GetListOfOrders();
                secondWorkWithLINQToXML.CountStatisticsByMonths().TryGetValue(8, out secondCount);

                Assert.AreEqual(1, firstCount - secondCount);
            }

            [TestMethod]
            public void TestForCountStatisticsByYears()
            {
                int firstCount, secondCount;
                workWithLINQToXML.GetListOfOrders();
                workWithLINQToXML.CountStatisticsByYears().TryGetValue(1998, out firstCount);

                WorkWithLINQToXML secondWorkWithLINQToXML = new WorkWithLINQToXML();

                secondWorkWithLINQToXML.Doc.Element("customers").FirstNode.Remove();
                secondWorkWithLINQToXML.GetListOfOrders();
                secondWorkWithLINQToXML.CountStatisticsByYears().TryGetValue(1998, out secondCount);

                Assert.AreEqual(3, firstCount - secondCount);
            }

            [TestMethod]
            public void TestForCountStatisticsByDate()
            {
                int firstCount, secondCount;
                workWithLINQToXML.GetListOfOrders();
                workWithLINQToXML.CountStatisticsByDate().TryGetValue("1997.08", out firstCount);

                WorkWithLINQToXML secondWorkWithLINQToXML = new WorkWithLINQToXML();

                secondWorkWithLINQToXML.Doc.Element("customers").FirstNode.Remove();
                secondWorkWithLINQToXML.GetListOfOrders();
                secondWorkWithLINQToXML.CountStatisticsByDate().TryGetValue("1997.08", out secondCount);

                Assert.AreEqual(1, firstCount - secondCount);
            }

        }
    }
}
