using OpenQA.Selenium;
using WebDriverCore.Browser;

namespace WebDriverCore
{
    public sealed class BrowserFactory
    {
        private static IBrowser browserDriver;

        public static IWebDriver Driver { get; set; }

        public static void InitBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    if (Driver == null)
                    {
                        browserDriver = new ChromeBrowser();
                        browserDriver.InitDriver();
                        Driver = browserDriver.GetDriver;
                    }
                    break;

                case "Edge":
                    if (Driver == null)
                    {
                        browserDriver = new EdgeBrowser();
                        browserDriver.InitDriver();
                        Driver = browserDriver.GetDriver;
                    }
                    break;

                case "Firefox":
                    if (Driver == null)
                    {
                        browserDriver = new FirefoxBrowser();
                        browserDriver.InitDriver();
                        Driver = browserDriver.GetDriver;
                    }
                    break;
            }
        }
    }
}