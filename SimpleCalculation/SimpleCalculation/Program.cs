using System;
using System.Configuration;

namespace SimpleCalculation
{
    class Program
    {

        static ActionUtil action = new ActionUtil();

        static void Main(string[] args)
        {

            if (bool.Parse(ConfigurationManager.AppSettings["UsingConsole"]))
            {
                action.DoConsole();
                if (bool.Parse(ConfigurationManager.AppSettings["UsingLibrary"]))
                {

                    action.CalculateExternal();
                }
                else
                {
                    action.CalculateInternal();
                }

            }
            else
            {
                action.DoResource();
                if (bool.Parse(ConfigurationManager.AppSettings["UsingLibrary"]))
                {
                    action.CalculateExternal();
                }
                else
                {


                    action.CalculateInternal();
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }



    }
}

