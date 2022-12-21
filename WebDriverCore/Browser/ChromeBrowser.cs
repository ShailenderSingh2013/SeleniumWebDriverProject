using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using WebDriverCore;
using WebDriverManager.DriverConfigs.Impl;

namespace WebDriverCore
{
    public sealed class ChromeBrowser :IBrowser  
    {
        private IWebDriver _driver;

        BrowserType IBrowser.Type => (BrowserType)Enum.Parse(typeof(BrowserType), "Chrome");

        IWebDriver IBrowser.GetDriver => _driver;

        public void InitDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver= new ChromeDriver(options);
        }

        

        // TODO - Fix Remote WebDriver
        //IBrowser<RemoteWebDriver> IBrowserWebDriver<RemoteWebDriver>.Create()
        //{
        //    DesiredCapabilities capabilities;
        //    var gridUrl = Config.GridHubUri;

        //    switch (Config.Browser)
        //    {
        //        case BrowserType.Chrome:
        //            capabilities = new DesiredCapabilities();
        //            break;
        //        case BrowserType.Firefox:
        //            capabilities = new DesiredCapabilities();
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }

        //    if (Config.RemoteBrowser && Config.UseSauceLabs)
        //    {
        //        capabilities.SetCapability(CapabilityType.Version, "50");
        //        capabilities.SetCapability(CapabilityType.Platform, "Windows 10");
        //        capabilities.SetCapability("username", Config.SauceLabsUsername);
        //        capabilities.SetCapability("accessKey", Config.SauceLabsAccessKey);
        //        gridUrl = Config.SauceLabsHubUri;
        //    }
        //    else if (Config.RemoteBrowser && Config.UseBrowserstack)
        //    {
        //        capabilities.SetCapability(CapabilityType.Version, "50");
        //        capabilities.SetCapability(CapabilityType.Platform, "Windows 10");
        //        capabilities.SetCapability("username", Config.BrowserStackUsername);
        //        capabilities.SetCapability("accessKey", Config.BrowserStackAccessKey);
        //        gridUrl = Config.BrowserStackHubUrl;
        //    }

        //    return
        //        new BrowserAdapter<RemoteWebDriver>(
        //            new RemoteWebDriver(new Uri(gridUrl), capabilities), BrowserType.Remote);
        //}
    }
}