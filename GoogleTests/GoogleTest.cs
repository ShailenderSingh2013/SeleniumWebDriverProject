using AutomationHelper;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using WebDriverCore;

namespace GoogleTests
{
    [TestFixture]
    [Parallelizable]
    public class GoogleTest : TestBase
    {
        [Test]
        //[TestCaseSource(typeof(TestBase),"BrowserToRunWith")]
        public void TestMethod()
        {

            //test = AutomationHelper.Reporter.Reporter.ReportManager.CreateTest("TestMethod").Info("Test Started..");
            BaseComponent.LaunchBrowser("http://google.co.in");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys("Selenium Webdriver");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys(Keys.Tab);

            BaseComponent.GetDefaultElement(Pages.home.SearchButton).Click();

            Assert.AreEqual(BaseComponent.Driver.Title, "Selenium Webdriver - Google Search");
        }

        [Test]
        public void TestMethod2()
        {
            BaseComponent.LaunchBrowser("http://google.co.in");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys("Selenium Tutorial");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys(Keys.Tab);
            
            BaseComponent.GetDefaultElement(Pages.home.SearchButton).Click();
            
            Assert.AreEqual(BaseComponent.Driver.Title, "Selenium Tutorial - Google Search");
        }

        [Test]
        public void TestMethod3()
        {
            BaseComponent.LaunchBrowser("http://google.co.in");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys("C# Tutorial");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys(Keys.Tab);
            Thread.Sleep(5000);
            BaseComponent.GetDefaultElement(Pages.home.SearchButton).Click();
            
            Assert.AreEqual(BaseComponent.Driver.Title, "C# Tutorial - Google Search");
        }

        [Test]
        public void TestMethod4()
        {
            BaseComponent.LaunchBrowser("http://google.co.in");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys("Java Tutorial");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys(Keys.Tab);
            
            BaseComponent.GetDefaultElement(Pages.home.SearchButton).Click();
            
            Assert.AreEqual(BaseComponent.Driver.Title, "Java Tutorial - Google Search");
        }

        [Test]
        public void TestMethod5()
        {
            BaseComponent.LaunchBrowser("http://google.co.in");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys("Appium Tutorial");
            BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys(Keys.Tab);

            BaseComponent.GetDefaultElement(Pages.home.SearchButton).Click();

            Assert.AreEqual(BaseComponent.Driver.Title, "Appium Tutorial - Google Search");
        }
    }
}
