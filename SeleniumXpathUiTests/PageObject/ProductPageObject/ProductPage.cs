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
        // Заглушка когда таблица с продуктами не создана 
        private IWebElement _noProductExcistText => browser.WebDriver.FindElement(By.XPath("//p[text()=' No product exists.']"));
        // Заголовок страницы 
        private IWebElement _productPageTitle => browser.WebDriver.FindElement(
            By.XPath("//h2[@class='text-primary']"));
        // Таблица с созданными продуктами 
        private IWebElement _productTable => browser.WebDriver.FindElement(
            By.XPath("//table[@class='table table-bordered table-striped']"));
        // Список со значениями Product Name 
        private List<IWebElement> _productNamesList => browser.WebDriver.FindElements(
           By.XPath("//td[@width='30%']")).ToList();
        // Список со значениями Price 
        private List<IWebElement> _priceList => browser.WebDriver.FindElements(
          By.XPath("//td[@width='10%']")).ToList();
        // Список со значениями Category 
         private List<IWebElement> _categoryList => browser.WebDriver.FindElements(
          By.XPath("//td[@test_id='Category Name']")).ToList();
        // Список со значениями ApplicationType 
        private List<IWebElement> _applicationType => browser.WebDriver.FindElements(
         By.XPath("//td[@test_id='Category Name']")).ToList();
        // Список заголовков таблицы продуктов 
        private List<IWebElement> _prodcuctTableTitlesList => browser.WebDriver.FindElements(
         By.XPath("//table[@class='table table-bordered table-striped']//th[text()]")).ToList();//a[@class='btn btn-primary mx-2']
        // Список элементов кнопки редактирования в продукта в таблице 
        private List<IWebElement> _updateProductButtonList => browser.WebDriver.FindElements(
         By.XPath("//a[@class='btn btn-primary mx-2']")).ToList();
        // Список кнопок удаления продуктов из таблицы 
        private List<IWebElement> _deleteProductButtonList => browser.WebDriver.FindElements(
        By.XPath("//a[@class='btn btn-primary mx-2']")).ToList();
    }

}
