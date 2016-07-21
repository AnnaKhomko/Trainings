using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Driver
{
    public class FirefoxDriverInitializer
    {
        public IWebDriver CreateFirefoxDriver()
        {
            return new FirefoxDriver();
        }
    }
}
