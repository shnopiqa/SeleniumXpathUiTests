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
        private IWebElement HomePageButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/' and text() = 'Home']"));
        // Список эелементом в выпадающем списке настроек в хедер сайта 
        private List<IWebElement> ContentManagmentList => browser.WebDriver.FindElements(
            By.XPath("//a[@id='navbarDropdown']")).ToList();
        // Кнопка с выпадющим списком настроек контента 
        private IWebElement ContentManagmentDropDown => browser.WebDriver.FindElement(
            By.XPath("//a[@id='navbarDropdown']"));
        // Кнопка раздела категории товара 
        private IWebElement CategoryButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/Category']"));
        // Кнопка раздела со списком типов приложений 
        private IWebElement ApplicationTypeButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/ApplicationType']"));
        // Кнопка с разделом списка продуктов 
        private IWebElement ProductButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/ApplicationType']"));
        // Кнопка с разделом создания админа для сайта 
        private IWebElement CreateAdminUserButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/ApplicationType']"));
        // Кнопка с разделом корзины товаров 
        private IWebElement ShoppingCartButton => browser.WebDriver.FindElement(
            By.XPath("//a[@href='/Cart']"));
        // Кнопка перехода в настройки профиля авторизованного пользователя 
        private IWebElement ProfileNameButton => browser.WebDriver.FindElement(
           By.XPath("//a[@id='manage']"));
        // Керпка выхода из аккаунта 
        private IWebElement LogOutButton => browser.WebDriver.FindElement(
            By.XPath("//a[@id='logout'"));
        // Кнопка входа в аккаунт 
        private IWebElement LogInButton => browser.WebDriver.FindElement(
            By.XPath("//a[@id='login'"));
        // Кнопка регистрации 
        private IWebElement RegistrationButton => browser.WebDriver.FindElement(
           By.XPath("//a[@id='login'"));
        private IWebElement LabelToHomePageButton => browser.WebDriver.FindElement(
          By.XPath("//a[@class='navbar-brand']'"));
    }
}
