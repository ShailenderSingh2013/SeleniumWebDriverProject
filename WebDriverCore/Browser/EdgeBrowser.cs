using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace WebDriverCore.Browser
{
    public class EdgeBrowser : IBrowser
    {
        private IWebDriver _driver;
        public BrowserType Type => (BrowserType)Enum.Parse(typeof(BrowserType), "Edge");

        public IWebDriver GetDriver => _driver;

        public void InitDriver()
        {
            var service = EdgeDriverService.CreateDefaultService();
            service.UseVerboseLogging = true;
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            _driver = new EdgeDriver(service);
            _driver.Manage().Window.Maximize();
        }
    }
}
