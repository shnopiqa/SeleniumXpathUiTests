using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using SeleniumXpathUiTests.PageObject.BasePageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.PageObject.ProductPageObject
{
    public class ProductPage : BasePage
    {
        public ProductPage(IBrowser browser) : base(browser)
        {
        }
        //Кнопка создания продукта 
        private IWebElement _createNewProductButton => browser.WebDriver.FindElement(
            By.XPath("//a[@class='btn btn-primary fa-pull-right']"));
    }
}
