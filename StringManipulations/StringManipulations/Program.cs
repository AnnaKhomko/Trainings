using System;

namespace StringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            Manipulations manipulations = new Manipulations();
            string choice;
            string text;
            string[] sentences;
            Console.WriteLine("Do you want to get text from file? (yes/no)");
            choice = Console.ReadLine();
            if (choice.Equals("yes"))
            {
                text = manipulations.ReadFromFile(ResourceData.Path);
                Console.WriteLine("Initial text : {0}", text);
            }

            else
            {
                Console.WriteLine("Enter string");
                text = Console.ReadLine();
            }

            text = text.ToLower();
            sentences = manipulations.ParseToSentences(text);
            manipulations.PrintText(sentences);
            manipulations.WriteToFile(sentences, ResourceData.Path);
            Console.ReadLine();
        }

       
    }
}
