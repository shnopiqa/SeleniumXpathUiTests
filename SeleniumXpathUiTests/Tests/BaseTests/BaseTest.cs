using SeleniumXpathUiTests.BrowserHelpers;
using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using SeleniumXpathUiTests.PageObject.BasePageObject;

namespace SeleniumXpathUiTests.Tests.BaseTests
{
    public class BaseTest : IDisposable
    {
        protected IBrowser _browser;
        protected BrowserFactory _browserFactory;
        protected BasePage _basePage;
        public BaseTest(BrowsersTypes browserType)
        {
            _browserFactory = new BrowserFactory();
            _browser = _browserFactory.CreateBrowser(browserType);
            _browser.WebDriver.Manage().Window.Maximize();
        }

        public void InitalizeBasePage()
        {
            _basePage = new BasePage(_browser);
        }
        public void Dispose()
        {
            _browser.WebDriver.Quit();
        }

    }
}
