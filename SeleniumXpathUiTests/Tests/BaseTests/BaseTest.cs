using SeleniumXpathUiTests.BrowserHelpers;
using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using SeleniumXpathUiTests.PageObject.BasePageObject;
using SeleniumXpathUiTests.PageObject.HomePageObject;

namespace SeleniumXpathUiTests.Tests.BaseTests
{
    public class BaseTest : IDisposable
    {
        protected IBrowser _browser;
        protected BrowserFactory _browserFactory;
        protected BasePage _basePage;
        protected HomePage _homePage; 
        public BaseTest(BrowsersTypes browserType)
        {
            _browserFactory = new BrowserFactory();
            _browser = _browserFactory.CreateBrowser(browserType);
            _browser.WebDriver.Manage().Window.Maximize();
        }
        public void InitalizeHomePage() 
        {
            _homePage = new HomePage(_browser);
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
