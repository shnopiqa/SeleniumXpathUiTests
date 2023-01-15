using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumXpathUiTests.BrowserHelpers.Interface;

namespace SeleniumXpathUiTests.Tests.TestHelpers
{
    public class WaitHelper
    {
        public static void WaitUntilElementIsVisable(IBrowser browser, By locator, int timeOutInSeconds)
        {
            var wait = new WebDriverWait(browser.WebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            wait.Until(d => d.FindElements(locator).Any());
        }
        public static void WaitUntilEelementIsClickable(IBrowser browser, By locator, int timeOutinSeconds)
        {
            var wait = new WebDriverWait(browser.WebDriver, TimeSpan.FromSeconds(timeOutinSeconds));
            wait.Until(d =>
            {
                var element = d.FindElement(locator);
                return element.Enabled;
            });
        }
        public static void WaitUntilLoadingPage(IBrowser browser, int fromSeconds)
        {
            browser.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(fromSeconds);
        }
    }
}
