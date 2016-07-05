using System;
using System.Collections.Generic;
using System.IO;

namespace WorkWithDirectory
{
    public class WorkWithDirectory
    {
        public void MakeDirectory(string path)
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

        public void MakeFile(string path)
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
                var FileStream = File.Create(path);
                Console.WriteLine("The file was created successfully ");
                FileStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public List<string> CopyLines(string path)

        {
            StreamReader fs = new StreamReader(path);
            List<string> strings = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                strings.Add(fs.ReadLine());
            }

            return strings;
        }

        public void WriteToFile(List<string> text, string path)
        {
            File.AppendAllLines(path,text);   
        }
    }
}
