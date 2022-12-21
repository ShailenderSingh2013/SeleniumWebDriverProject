using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace WebDriverCore.Browser
{
    class FirefoxBrowser:IBrowser 
    {
        private IWebDriver _driver;

        BrowserType IBrowser.Type => (BrowserType)Enum.Parse(typeof(BrowserType), "Firefox");

        IWebDriver IBrowser.GetDriver => _driver;

        public void InitDriver()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArguments("--start-maximized");
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            _driver = new FirefoxDriver(options);
        }
    }
}
