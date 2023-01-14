using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.Interface;

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
