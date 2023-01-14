using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using SeleniumXpathUiTests.BrowserHelpers;
using SeleniumXpathUiTests.PageObject.BasePageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.Tests.BaseTests
{
    public class BaseTest : IDisposable
    {
        protected IBrowser _browser;
        protected BrowserFactory _browserFactory;
        protected BasePage _browserPage;
        public BaseTest(BrowsersTypes browserType)
        {
            _browserFactory = new BrowserFactory();
            _browser = _browserFactory.CreateBrowser(browserType);
            _browser.WebDriver.Manage().Window.Maximize();
        }

        public void InitalizeBasePage()
        {
            _browserPage = new BasePage(_browser);
        }
        public void Dispose()
        {
            _browser.WebDriver.Quit();
        }

    }
}
