using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TimeMeasurement measurement = new TimeMeasurement();
            List<string> result = new List<string>();
            Console.WriteLine("Please wait... ");
            measurement.MesureTimeForAdding();
            measurement.MesureTimeForReading();
            measurement.MesureTimeForFinding();
            measurement.MesureTimeForRemoving();
            measurement.WriteToLogFile(ResourceData.FilePath);
            Console.WriteLine($"Process was finished you can see results in log file.\n Path {ResourceData.FilePath}");
            Console.ReadLine();

        }
    }
}
