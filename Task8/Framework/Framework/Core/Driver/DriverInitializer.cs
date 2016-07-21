using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driverInstance;

        private Driver()
        {
        }

        public static IWebDriver GetDriver ()
        {
                return driverInstance;
        }


        public static IWebDriver CreateDriver()
        {
            string browser = ConfigurationManager.AppSettings["CurrentBrowser"];
            switch (browser)
            {
                case "Firefox":
                    {
                        return new FirefoxDriver();
                    }
                case "Chrome":
                    {
                        return new ChromeDriver();
                    }
                case "Opera":
                    {
                        return new OperaDriver();
                    }
                case "IE":
                    {
                        return new InternetExplorerDriver();
                    }
                case "Safari":
                    {
                        return new SafariDriver();
                    }
                default: return null;
            }
        }

    }
}
