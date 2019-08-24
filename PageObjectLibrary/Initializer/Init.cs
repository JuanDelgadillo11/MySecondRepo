using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using PageObjectLibrary.Base;
using System;

namespace PageObjectLibrary.Initializer
{
    public class Init :BaseDriver
    {
        public void OpenBrowser()
        {
            string browserType = "chrome";
            switch (browserType)
            {
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    //options.AddArgument("--start-maximized");
                    //options.AddArgument("--incognito");
                    SetDriver(new ChromeDriver(@"C:\SeleniumWebDrivers", options));
                    break;
                case "Firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("--start-maximized");
                    firefoxOptions.AddArgument("--incognito");
                    SetDriver(new FirefoxDriver(@"C:\SeleniumWebDrivers", firefoxOptions));
                    break;
                //Here I can add other browsers like IE or Edge.
            }
            
            //implicit timeouts.
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GetDriver().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
        }

        public void CloseBrowser()
        {
            GetDriver().Close();
            GetDriver().Quit();
        }
    }
}