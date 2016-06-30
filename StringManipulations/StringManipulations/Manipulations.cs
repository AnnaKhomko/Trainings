using System;
using System.IO;

namespace StringManipulations
{
    class Manipulations
    {
        public string ReadFromFile(string path)
        {
            string text = File.ReadAllText(path);
            return text;
        }

        public string[] ParseToSentences(string text)
        {
            System.Text.RegularExpressions.Regex sentenceRegEx = new System.Text.RegularExpressions.Regex(@"[.!?]");
            string[] sentences = sentenceRegEx.Split(text);
            return sentences;
        }

        public void PrintText(string[] sentences)
        {
            int i = 0;
            while (i < sentences.Length)
            {
                sentences[i] += '\n';
                Console.Write(DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss:fff") + " " + sentences[i]);
                i++;
            }
        }

        public void WriteToFile(string[] sentences, string path)
        {
            File.WriteAllLines(path, sentences);
        }
    }
}
