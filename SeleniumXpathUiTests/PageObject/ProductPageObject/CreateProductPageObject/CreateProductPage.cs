using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using SeleniumXpathUiTests.PageObject.BasePageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.PageObject.ProductPageObject.CreateProductPageObject
{
    public class CreateProductPage : BasePage
    {
        public CreateProductPage(IBrowser browser): base(browser)
        {

        }
        // Заголовок поля создания продукта Name 
        private IWebElement _productNameFieldTitle => browser.WebDriver.FindElement(
            By.XPath("//div//label[@for='Product_Name']"));
        // Поле ввода имени продукта Name
        private IWebElement _productNameField => browser.WebDriver.FindElement(
            By.XPath("//div//input[@id='Product_Name']]"));
        // Заголовок поля Price
        private IWebElement _productPriceFieldTitle => browser.WebDriver.FindElement(
           By.XPath("//div//label[@for='Product_Price']"));
        // Поле ввода цены продукта Price
        private IWebElement _productPrieeFIeldT => browser.WebDriver.FindElement(
            By.XPath("//div//input[@id='Product_Price']"));
        // Заголовок поля Price
        private IWebElement _productDescriptionFieldTitle => browser.WebDriver.FindElement(
           By.XPath("//label[@for='Product_Description']"));
        // Поле ввода цены продукта Price
        private IWebElement _productDescriptionFIeld => browser.WebDriver.FindElement(
            By.XPath("//div[@class='note-editable']"));
        // Заголовок поля загрузки изображения Image
        private IWebElement _productImageFIeld => browser.WebDriver.FindElement(
        By.XPath("//div[contains(text(), 'Image')]"));

        // Поле загрузки изображения Image
        private IWebElement _productImageFIeldTitle => browser.WebDriver.FindElement(
         By.XPath("//input[@type='file' and @id='uploadBox']"));
        // Заколовок селектора выбора категории
        private IWebElement _productCategoryFieldTitle => browser.WebDriver.FindElement(
         By.XPath("//label[@for='Product_CategoryId']"));
        // Поле селектора выбора категории товара 
        private IWebElement _productCategorySelector=> browser.WebDriver.FindElement(
         By.XPath("//select[@id='Product_CategoryId']"));
        // Заголовок селектора выборака  ApptypeId
        private IWebElement _producAppTypeIdSelectorTitle => browser.WebDriver.FindElement(
         By.XPath("//label[@for='Product_AppTypeId']"));
        // Поле селектора выбора AppTypeId товара 
        private IWebElement _producAppTypeIdSelector => browser.WebDriver.FindElement(
         By.XPath("//select[@id='Product_AppTypeId']"));
    }
}
