using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithDirectory
{
    class Program
    {
        static string ditectoryName, fileName;
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            Console.WriteLine("Enter name of directory you want to create");
            ditectoryName = Console.ReadLine();
            ditectoryName = ResourceData.DirectoryPath + "/" + ditectoryName;
            MakeDirectory(ditectoryName);
            Console.WriteLine("Enter name of file you want to create");
            fileName = Console.ReadLine();
            fileName = ditectoryName + "/" + fileName;
            MakeFile(fileName);
            strings = CopyLines(ResourceData.FilePath);
            WriteToFile(strings, fileName);

            Console.ReadLine();
        }

        public static void MakeDirectory(string path)
        {
            try
            {

                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully ");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public static void MakeFile(string path)
        {
            try
            {

                // Determine whether the file exists.
                if (File.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the file.
                File.Create(path);
                Console.WriteLine("The file was created successfully ");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public static List <string> CopyLines(string path)
        {
            StreamReader fs = new StreamReader(path);
            List <string> strings = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                strings.Add(fs.ReadLine());
            }

            return strings;
        }

        public static void WriteToFile(List <string> text, string path)
        {
            StreamWriter aw = new StreamWriter(path);
            aw.WriteLine(text);
        }
    }


}
