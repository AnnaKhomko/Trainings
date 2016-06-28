using System;
using System.IO;
namespace StringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string text;
            Console.WriteLine("Do you want to get text from file? (yes/no)");
            choice = Console.ReadLine();
            if (choice.Equals("yes"))
            {

                text = File.ReadAllText(Resource1.Path);
                Console.WriteLine(text);
                text = text.ToLower();
                System.Text.RegularExpressions.Regex sentenceRegEx = new System.Text.RegularExpressions.Regex(@"[.!?]");
                string[] sentences = sentenceRegEx.Split(text);
                int i = 0;
                while (i < sentences.Length)
                {
                    Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss:fff") + " " + sentences[i]);
                    i++;
                }

            }
            else
            {
                Console.WriteLine("Enter string");
                text = Console.ReadLine();
                text = text.ToLower();
                System.Text.RegularExpressions.Regex sentenceRegEx = new System.Text.RegularExpressions.Regex(@"[.!?]");
                string[] sentences = sentenceRegEx.Split(text);
                int i = 0;
                while (i < sentences.Length)
                {
                    Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss:fff") + " " + sentences[i]);
                    i++;
                }

            }
            Console.ReadLine();
        }
    }
}
