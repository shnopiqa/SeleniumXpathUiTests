using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using SeleniumXpathUiTests.PageObject.BasePageObject;
using SeleniumXpathUiTests.PageObject.HomePageObject.ProductHelper;
using SeleniumXpathUiTests.PageObject.WaitHelpersForPageObject;
using System.Diagnostics;

namespace SeleniumXpathUiTests.PageObject.HomePageObject
{
    public class HomePage:BasePage
    {
        public HomePage(IBrowser browser) : base(browser)
        {
        }
        // Список всех тегов фильтра по категории товаров 
        private List<IWebElement> _tagsCategoryFilterList => browser.WebDriver.FindElements(
            By.XPath("//div[@class='text-center']")).ToList();
        // Список с изображениями товаров 
        private List<IWebElement> _listProductsImages => browser.WebDriver.FindElements(
            By.XPath("//img[@class='card-img-top img-fluid d-block mx-auto mb-3']")).ToList();
        // Список с названием товаров
        private List<IWebElement> _productNamesList => browser.WebDriver.FindElements(
            By.XPath("//label[@class='float-left']")).ToList();
        // Список с ценами товаров
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
        // Получение первого продукта из списка продуктов 
        public Product InitializeFirstOrDefaultProductCard() 
        {
            WaitHelperPage.WaitUntilElementIsVisable(browser, _productNamesList.LastOrDefault(), 5);
            WaitHelperPage.WaitUntilElementIsVisable(browser, _productPriceList.LastOrDefault(), 5);
            WaitHelperPage.WaitUntilElementIsVisable(browser, _productDescriptionsList.LastOrDefault(), 5);
            WaitHelperPage.WaitUntilElementIsVisable(browser, _listProductsImages.LastOrDefault(), 5);
            WaitHelperPage.WaitUntilElementIsVisable(browser, _categoryTypesList.LastOrDefault(), 5);
            WaitHelperPage.WaitUntilElementIsVisable(browser, _applicationTypeList.LastOrDefault(), 5);
            return new Product()
            {

                Name = _productNamesList.Select(x => x.Text).FirstOrDefault(),
                Price = _productPriceList.Select(x => x.Text).FirstOrDefault(),
                Description = _productDescriptionsList.Select(x => x.Text).FirstOrDefault(),
                Image = _listProductsImages.Select(x => x.GetAttribute("src")).FirstOrDefault().ToString(),
                CategoryType = _categoryTypesList.Select(x => x.Text).FirstOrDefault(),
                ApplicationType = _applicationTypeList.Select(x => x.Text).FirstOrDefault()
            };
        }
        // Получение значений последнего продукта из списка продуктов 
        public Product InitializeLastOrDefaultProductCard() => new Product()
        {
            Name = _productNamesList.Select(x => x.Text).LastOrDefault(),
            Price = _productPriceList.Select(x => x.Text).LastOrDefault(),
            Description = _productDescriptionsList.Select(x => x.Text).LastOrDefault(),
            Image = _listProductsImages.Select(x => x.GetAttribute("src")).LastOrDefault().ToString(),
            CategoryType = _categoryTypesList.Select(x => x.Text).LastOrDefault(),
            ApplicationType = _applicationTypeList.Select(x => x.Text).LastOrDefault()
        };
        // Перейти на страницу 1 в списке продукта  
        public void GetFristProductCardDetailPage() 
        {
            if(_viewDetailsButtons.Count != 0) 
            {
                WaitHelperPage.WaitUntilEelementIsClickable(browser, _viewDetailsButtons.FirstOrDefault(), 5);
                _viewDetailsButtons.FirstOrDefault().Click();
            }
            else 
            {
                throw new Exception($"Колличество кнопок деталей продукта = {_viewDetailsButtons.Count}");
            }   
        }
        // Перейти на страницу последнего  в списке продукта 
        public void GetLasttProductCardDetailPage()
        {
            if (_viewDetailsButtons.Count != 0)
            {
                WaitHelperPage.WaitUntilEelementIsClickable(browser, _viewDetailsButtons.LastOrDefault(), 5);
                _viewDetailsButtons.LastOrDefault().Click();
            }
            else
            {
                throw new Exception($"Колличество кнопок деталей продукта = {_viewDetailsButtons.Count}");
            }
        }
        // Выбрать первый фильтр по категориям в списке 
        public void GetFirstCategoryFiler() 
        {
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _tagsCategoryFilterList.FirstOrDefault(), 5);
            _tagsCategoryFilterList.Select(x => x).FirstOrDefault().Click();
        }
        // Выбрать последний  фильтр по категориям в списке 
        public void GeLastOrDefaultCategoryFiler()
        {
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _tagsCategoryFilterList.LastOrDefault(), 5);
            _tagsCategoryFilterList.Select(x => x).LastOrDefault().Click();
        }


    }
}
