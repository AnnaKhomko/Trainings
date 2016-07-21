using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class ConsoleWriter
    {
        public void WriteToConsole()
        {
            Catalog catalog = new Catalog();
            Deserialization ds = new Deserialization();
            catalog = ds.Deserialise();
            Serialization sz = new Serialization();
            sz.Serialize(catalog);
            Console.WriteLine("Serialization an diserialization was successfully completed.");
            Console.WriteLine($"You can check the results in {ResourceData.FilePathAfterSearealisation} file. ");


        }
    }
}
