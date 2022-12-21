using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverCore;

namespace AutomationHelper
{
    public class BaseComponent
    {
        public static IWebDriver Driver => BrowserFactory.Driver;
      

        //Launch Url
        public static void LaunchBrowser(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElemetPresent(locator))
                return Driver.FindElement(locator);
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }

        public static IWebElement GetDefaultElement(By locator)
        {
            IList<IWebElement> elements = Driver.FindElements(locator);

            return elements[1];
            //if (IsElemetPresent(locator))
            //    return Driver.FindElement(locator);
            //else
            //    throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }
        public static bool IsElemetPresent(By locator)
        {
            try
            {
                return Driver.FindElements(locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
