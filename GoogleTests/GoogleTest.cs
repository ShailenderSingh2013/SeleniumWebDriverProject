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

            Thread.Sleep(5000);
            BaseComponent.GetDefaultElement(Pages.home.SearchButton).Click();
            Thread.Sleep(5000);
            Assert.AreEqual(BaseComponent.Driver.Title, "Selenium Webdriver - Google Search");
        }

        //[Test]
        ////[TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        //public void TestMethod2()
        //{

        //    //test = AutomationHelper.Reporter.Reporter.ReportManager.CreateTest("TestMethod").Info("Test Started..");
        //    BaseComponent.LaunchBrowser("http://google.co.in");
        //    //BaseComponent.GetElement(Pages.home.SearchTextBox).SendKeys("Selenium Webdriver");
        //    //Thread.Sleep(5000);
        //    //BaseComponent.GetElement(Pages.home.SearchButton).Click();
        //    //Thread.Sleep(5000);

        //    Console.WriteLine();



        //}
    }
}
