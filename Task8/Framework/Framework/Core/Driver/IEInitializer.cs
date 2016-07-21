using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Driver
{
    public class IEInitializer
    {
        public IWebDriver CreateIEDriver()
        {
            return new InternetExplorerDriver();
        }
    }
}
