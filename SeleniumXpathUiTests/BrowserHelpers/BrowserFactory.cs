using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.BrowserHelpers
{
    public class BrowserFactory
    {
        private IWebDriver driver;
        public IBrowser CreateBrowser(BrowsersTypes browsersType)
        {

            switch (browsersType)
            {
                case BrowsersTypes.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case BrowsersTypes.Chrome:
                    driver = new ChromeDriver();
                    break;
                case BrowsersTypes.Edge:
                    driver = new EdgeDriver();
                    break;
            }
            return new Browser(driver);
        }
    }
}
