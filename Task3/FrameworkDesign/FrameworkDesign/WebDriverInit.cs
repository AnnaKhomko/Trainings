using System;
using System.Configuration;

namespace FrameworkDesign
{
    public class WebDriverInit
    {
        public String browser = Convert.ToString(ConfigurationManager.AppSettings["Browser"]);

        public void ChooseBrowser(string browser)
        {
            switch (browser)
            {
                case "InternetExplorer":
                    {
                        break;
                    }
                case "Opera":
                    {
                        break;
                    }
                case "Firefox":
                    {
                        break;
                    }
                case "GoogleChrome":
                    {
                        break;
                    }
            }
        }
        
    }
}
