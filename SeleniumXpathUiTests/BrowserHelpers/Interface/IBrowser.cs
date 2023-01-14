using OpenQA.Selenium;

namespace SeleniumXpathUiTests.BrowserHelpers.Interface
{
    public interface IBrowser
    {
        public void Navigate(string url);
        IWebDriver WebDriver { get; }
    }
}
