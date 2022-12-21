using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverCore
{
    public interface IBrowser
    {
        BrowserType Type { get; }
        IWebDriver GetDriver { get; }
        void InitDriver();



    }
}
