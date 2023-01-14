using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.BrowserHelpers
{
    public class Browser : IBrowser
    {
        private IWebDriver driver;
        public Browser(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public IWebDriver WebDriver => driver;
    }
}
