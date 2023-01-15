using OpenQA.Selenium;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using SeleniumXpathUiTests.PageObject.HomePageObject;
using SeleniumXpathUiTests.PageObject.WaitHelpersForPageObject;

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
        // Логотип сайта для перехода на главную
        private IWebElement _labelToHomePageButton => browser.WebDriver.FindElement(
          By.XPath("//a[@class='navbar-brand']'"));
        // Перейти на главную страницу по клику на логотип 
        public void GetHomePageByLogo() 
        {
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _labelToHomePageButton, 10);
            _labelToHomePageButton.Click();
        }
        // Перейти на главную страницу по клику на кнопку Главная 
        public HomePage GetHomePageByHomeButton()
        {
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _labelToHomePageButton, 10);
            _labelToHomePageButton.Click();
            return new HomePage(browser);
        }
        // Открыть выпадающее меню со списком страниц управления продуктами 
        public void GetContentManagmentButtonsList()
        {
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _labelToHomePageButton, 10);
            _contentManagmentDropDown.Click();
        }
        // Открыть страницу настройки категорий товаров 
        public void GetCategoryPage() 
        {
            GetContentManagmentButtonsList();
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _categoryButton, 10);
            _categoryButton.Click();
        }
    }
}
