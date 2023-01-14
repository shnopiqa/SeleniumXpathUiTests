using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using SeleniumXpathUiTests.PageObject.BasePageObject;
using SeleniumXpathUiTests.PageObject.HomePageObject.Product;
using SeleniumXpathUiTests.PageObject.HomePageObject.ProductHelper;
using SeleniumXpathUiTests.PageObject.HomePageObject.ProductPageHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.PageObject.HomePageObject
{
    public class HomePage:BasePage
    {
  
        public HomePage(IBrowser browser) : base(browser)
        {

        }
        // Список всех товаров 
        private List<IWebElement> _productsList => browser.WebDriver.FindElements(
            By.XPath("//div[@class='row']")).ToList();
        // Список всех тегов фильтра товаров 
        private List<IWebElement> _tagsFilterList => browser.WebDriver.FindElements(
            By.XPath("//div[@class='text-center']")).ToList();
        // Список изображений товаров 
        private List<IWebElement> _listProductsImages => browser.WebDriver.FindElements(
            By.XPath("//img[@class='card-img-top img-fluid d-block mx-auto mb-3']")).ToList();
        // Список с названием товаров
        private List<IWebElement> _productNamesList => browser.WebDriver.FindElements(
            By.XPath("//label[@class='float-left']")).ToList();
        // Список с ценой товаров
        private List<IWebElement> _productPriceList => browser.WebDriver.FindElements(
            By.XPath("//span[@class='text-info h5']")).ToList();
        // Список с описанием товаров
        private List<IWebElement> _productDescriptionsList => browser.WebDriver.FindElements(
            By.XPath("//div[@class='col-12 pt-2']")).ToList();
        // Список с тегами категорий товаров 
        private List<IWebElement> _categoryTypesList => browser.WebDriver.FindElements(
            By.XPath("//span[@class='badge p-2 border w-100' and @style='background-color:palevioletred']")).ToList();
        // Список с тегами типов приложения 
        private List<IWebElement> _applicationTypeList => browser.WebDriver.FindElements(By.XPath("//span[@class='badge p-2 border w-100' and @style='background-color:lightskyblue']")).ToList();
        // Получение всех кнопок просмотра деталей определенного товара 
        private List<IWebElement> _viewDetailsButtons => browser.WebDriver.FindElements(By.XPath("//a[@class='btn btn-dark form-control btn-sm p-2']")).ToList();
        public Product InitializeFirstOrDefaultProductCard() 
        {
           return new Product()
           {
               Name = _productNamesList.Select(x => x.Text).FirstOrDefault(),
               Price = _productPriceList.Select(x => x.Text).FirstOrDefault(),
               Description = _productDescriptionsList.Select(x => x.Text).FirstOrDefault(),
               Image = _listProductsImages.Select(x => x.GetAttribute("src")).ToString(),
               CategoryType = _categoryTypesList.Select(x => x.Text).FirstOrDefault(),
               ApplicationType = _applicationTypeList.Select(x => x.Text).FirstOrDefault()
           };
        }

    }
}
