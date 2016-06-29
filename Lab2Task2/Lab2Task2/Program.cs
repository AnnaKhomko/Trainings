using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countInt = 0;
            int countFloat = 0;
            double averageInt, averageFloat;
            List<int> integers = new List<int>();
            List<float> doubles = new List<float>();
            List<string> str = new List<string>();
            string flag = "";
           
            String separ = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;

            while (!flag.Equals("exit"))
            {
                Console.WriteLine("Enter real numbers in format: numbers{0}numbers", separ);
                Console.WriteLine("Enter string (to stop enter press exit)");
                flag = Console.ReadLine();
                if (flag.Equals("exit"))
                    continue;
                int dig1;

                if (Int32.TryParse(flag, out dig1))
                {
                    countInt++;
                    integers.Add(dig1);

                }

                else if (FintFloats(flag, separ))
                {
                    countFloat++;
                    doubles.Add(float.Parse(flag));

                }
                else str.Add(flag);


            }

            Console.WriteLine("Count of integer numbers: {0}", countInt);
            Console.WriteLine("Count of real numbers: {0}", countFloat);
            Console.WriteLine("Integer numbers:");
            foreach (var integer in integers)
                Console.WriteLine(Convert.ToString(integer).PadLeft(10));
            averageInt = GetAverageOfIntegers(integers);
            Console.WriteLine("Average: {0}",averageInt.ToString().PadLeft(10));
            Console.WriteLine("Real numbers:");
            foreach (var floa in doubles)
            {
                
                Console.WriteLine(Convert.ToString(floa.ToString("0.00")).PadLeft(10));
            }
                
           Console.WriteLine(doubles.Average().ToString("0.00").PadLeft(10));

            var result = str.OrderBy(x => x.Length).ThenBy(x => x);
            foreach (var s in result)
            {

                Console.WriteLine(s.PadLeft(10));
            }


            Console.ReadLine();


        }


        public static bool FintFloats(string str, string separator)
        {
            var res = new Regex(@"[0-9]+\" + separator + "[0-9]+");
            return res.IsMatch(str);
        }

        public static double GetAverageOfIntegers(List <int> integers)
        {
            double average = 0;
            average = integers.Average();
            return average;
        }

    }
}

