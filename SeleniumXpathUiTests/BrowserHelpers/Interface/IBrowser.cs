using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.BrowserHelpers.Interface
{
    public interface IBrowser
    {
        public void Navigate(string url);
        IWebDriver WebDriver { get; }
    }
}
