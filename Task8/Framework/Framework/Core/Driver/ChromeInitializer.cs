using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Driver
{
    public class ChromeInitializer
    {
        public IWebDriver CreateChromeDriver()
        {
            return new ChromeDriver();
        }
    }
}
