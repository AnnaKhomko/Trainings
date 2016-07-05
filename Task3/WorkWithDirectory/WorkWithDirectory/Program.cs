using System;
using System.Collections.Generic;
using System.Configuration;


namespace WorkWithDirectory
{
    class Program
    {
         
        static void Main(string[] args)
        {
            string ditectoryName, fileName;
            List<string> strings = new List<string>();
            WorkWithDirectory dir = new WorkWithDirectory();

            Console.WriteLine("Enter name of directory you want to create");
            ditectoryName = Console.ReadLine();
            ditectoryName = Convert.ToString(ConfigurationManager.AppSettings["DirectoryPath"]) + "/" + ditectoryName;

            dir.MakeDirectory(ditectoryName);
            Console.WriteLine("Enter name of file you want to create");
            fileName = Console.ReadLine();
            fileName = ditectoryName + "/" + fileName + ".txt";
            dir.MakeFile(fileName);
            strings = dir.CopyLines(Convert.ToString(ConfigurationManager.AppSettings["FilePath"]));
            dir.WriteToFile(strings, fileName);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
