using AutomationHelper.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverCore;

namespace AutomationHelper
{
    [SetUpFixture]
    [TestFixture]
    public class TestBase
    {

        protected static IWebDriver Driver => BrowserFactory.Driver;

        private static string browserName { get; set; }

        //public static IEnumerable<string> BrowserToRunWith()
        //{
        //    string[] browsers = AutomationSettings.browsersTorunWith.Split(',');

        //    foreach (string item in browsers)
        //    {
        //        browserName = item.Trim();
        //        yield return item.Trim();
        //    }
        //}

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Reporter.Reporter.GetReportManager();
        }

        [SetUp]
        public void Setup()
        {
            AutomationHelper.Reporter.Reporter.ReportManager.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test Started..");
            BrowserFactory.InitBrowser("Chrome");
            BaseComponent.LaunchBrowser(AutomationSettings.Url);
        }

        [TearDown]
        public void Close()
        {
            
            if(Driver!=null)
            {
                Driver.Quit();
                BrowserFactory.Driver = null;
            }
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Reporter.Reporter.ReportFlush();
        }

        
    }
}
