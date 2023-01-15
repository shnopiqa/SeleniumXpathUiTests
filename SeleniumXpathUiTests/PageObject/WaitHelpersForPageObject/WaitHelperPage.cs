using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.PageObject.WaitHelpersForPageObject
{
    public class WaitHelperPage
    {
        public static void WaitUntilElementIsVisable(IBrowser browser, IWebElement element, int timeOutInSeconds)
        {
            var wait = new WebDriverWait(browser.WebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            wait.Until(d => element.Displayed);
        }
        public static void WaitUntilEelementIsClickable(IBrowser browser, IWebElement element, int timeOutinSeconds)
        {
            var wait = new WebDriverWait(browser.WebDriver, TimeSpan.FromSeconds(timeOutinSeconds));
            wait.Until(d =>
            {
                return element.Enabled;
            });
        }
        public static void WaitUntilLoadingPage(IBrowser browser, int fromSeconds)
        {
            browser.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(fromSeconds);
        }
    }
}
