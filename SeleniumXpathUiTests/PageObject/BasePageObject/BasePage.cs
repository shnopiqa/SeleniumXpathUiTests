using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.PageObject.BasePageObject
{
    public class BasePage
    {
        public IBrowser browser;
        public BasePage(IBrowser browser)
        {
            this.browser = browser;
        }
        public void GoToPageUrl(string url)
        {
            browser.Navigate(url);
        }
        // Кнопка главная в хедер сайта 
        private IWebElement _homePageButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/' and text() = 'Home']"));
        // Список эелементом в выпадающем списке настроек в хедер сайта 
        private List<IWebElement> _contentManagmentList => browser.WebDriver.FindElements(
            By.XPath("//a[@id='navbarDropdown']")).ToList();
        // Кнопка с выпадющим списком настроек контента 
        private IWebElement _contentManagmentDropDown => browser.WebDriver.FindElement(
            By.XPath("//a[@id='navbarDropdown']"));
        // Кнопка раздела категории товара 
        private IWebElement _categoryButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/Category']"));
        // Кнопка раздела со списком типов приложений 
        private IWebElement _applicationTypeButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/ApplicationType']"));
        // Кнопка с разделом списка продуктов 
        private IWebElement _productButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/ApplicationType']"));
        // Кнопка с разделом создания админа для сайта 
        private IWebElement _createAdminUserButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/ApplicationType']"));
        // Кнопка с разделом корзины товаров 
        private IWebElement _shoppingCartButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/Cart']"));
        // Кнопка перехода в настройки профиля авторизованного пользователя 
        private IWebElement _profileNameButton => browser.WebDriver.FindElement(
           By.XPath("//a[@id='manage']"));
        // Керпка выхода из аккаунта 
        private IWebElement _logOutButton => browser.WebDriver.FindElement(
            By.XPath("//a[@id='logout'"));
        // Кнопка входа в аккаунт 
        private IWebElement _logInButton => browser.WebDriver.FindElement(
            By.XPath("//a[@id='login'"));
        // Кнопка регистрации 
        private IWebElement _registrationButton => browser.WebDriver.FindElement(
           By.XPath("//a[@id='login'"));
        private IWebElement _labelToHomePageButton => browser.WebDriver.FindElement(
          By.XPath("//a[@class='navbar-brand']'"));
    }
}
