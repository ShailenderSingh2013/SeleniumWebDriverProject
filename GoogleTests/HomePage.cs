using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverCore;

namespace GoogleTests
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        public HomePage()
        {
            _driver = BrowserFactory.Driver;
        }

        //Properties 
        //private readonly string SearchTextBox = "//input[@name='q']";
        public By SearchTextBox = By.XPath("//input[@name='q']");
        public By SearchButton = By.XPath("//input[@name='btnK']");


    }
}
