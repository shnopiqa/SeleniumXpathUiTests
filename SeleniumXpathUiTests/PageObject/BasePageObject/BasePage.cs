using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using SeleniumXpathUiTests.BrowserHelpers.Interface;
using SeleniumXpathUiTests.PageObject.HomePageObject;
using SeleniumXpathUiTests.PageObject.WaitHelpersForPageObject;
using SeleniumXpathUiTests.Tests.Helpers;

namespace SeleniumXpathUiTests.PageObject.BasePageObject
{
    public class BasePage
    {
        public IBrowser browser;
        protected ExceptionHandler _exceptionHandler;
        public BasePage(IBrowser browser)
        {
            this.browser = browser;
            _exceptionHandler = new ExceptionHandler();
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
            By.XPath("//a[@class ='nav-link']"));
        // Кнопка перехода в настройки профиля авторизованного пользователя 
        private IWebElement _profileNameButton => browser.WebDriver.FindElement(
           By.XPath("//a[@id='manage']"));
        // Керпка выхода из аккаунта 
        private IWebElement _logOutButton => browser.WebDriver.FindElement(
            By.XPath("//a[@id='logout']"));
        // Кнопка входа в аккаунт 
        private IWebElement _logInButton => browser.WebDriver.FindElement(
            By.XPath("//a[@id='login']"));
        // Кнопка регистрации 
        private IWebElement _registrationButton => browser.WebDriver.FindElement(
           By.XPath("//a[@id='register']"));
        // Логотип сайта для перехода на главную
        private IWebElement _labelToHomePageButton => browser.WebDriver.FindElement(
          By.XPath("//a[@class='navbar-brand']'"));
        // Футтер сайта 
        private IWebElement _footter => browser.WebDriver.FindElement(
            By.XPath("//footer/div[@class = 'container']"));
        // Перейти на главную страницу по клику на логотип 
        public void GetHomePageByLogo() 
        {
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _labelToHomePageButton, 10);
            _labelToHomePageButton.Click();
        }
        // Перейти на главную страницу с помощью кнопки Home
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
        // Открыть страницу настройки типов приложений 
        public void GetApplicationTypePage()
        {
            GetContentManagmentButtonsList();
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _applicationTypeButton, 10);
            _applicationTypeButton.Click();
        }
        // Открыть страницу управления продуктами
        public void GetProductPage()
        {
            GetContentManagmentButtonsList();
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _productButton, 10);
            _productButton.Click();
        }
        // Открыть страницу управления администраторами сайта
        public void GetCreateAdminUserPage()
        {
            GetContentManagmentButtonsList();
            WaitHelperPage.WaitUntilEelementIsClickable(browser, _createAdminUserButton, 10);
            _createAdminUserButton.Click();
        }
        // Проверка на заполненную или пустую корзину товаров 
        public bool ShopingCartIsNotEmpty() 
        {
            // Получить текст без пробелов в начале и конце строки 
            string cartValue = _shoppingCartButton.Text.Trim();

            // Удалить все, кроме значения колличества товаров 
            cartValue = new string(cartValue.Where(char.IsDigit).ToArray());
            // Проверка (корзина пустая или нет)
            bool cartIsNotEmpty = int.Parse(cartValue) > 0;
            return cartIsNotEmpty;

        }
        // Проверка на авторизацию пользователя 
        public bool UserIsAuthorize() 
        {
            bool userIsAuthorized = true;
            try 
            {
                if (_profileNameButton.Enabled && _logOutButton.Enabled)
                {
                    userIsAuthorized = true;
                }
            }
            catch(Exception ex)
            {
                userIsAuthorized = false;
            }
            return userIsAuthorized;
        }
        // Открыть корзину с товарами 
        public void GetShopingCartPage()
        {
            bool shopingCartInsNotEmpty = ShopingCartIsNotEmpty();
            bool userIsAuthorize = UserIsAuthorize();
            if (shopingCartInsNotEmpty == true && userIsAuthorize == true)
            {
                WaitHelperPage.WaitUntilEelementIsClickable(browser, _shoppingCartButton, 10);
                _shoppingCartButton.Click();
            }
            else
            {
                throw new Exception($"Корзина пуста или пользователь не авторизован, результат проверки ShopingCartIsNotEmpty: {shopingCartInsNotEmpty}, UserIsAuthorize : {userIsAuthorize}"); 
            }
        }
        // Открыть страницу регистрации  пользоваателя 
        public void GetRegisterPage() 
        {
            bool userIsAuthorize = UserIsAuthorize();
            _exceptionHandler.HandleException(() =>
            {
                if (userIsAuthorize == false)
                {
                    WaitHelperPage.WaitUntilEelementIsClickable(browser, _registrationButton, 10);
                    _registrationButton.Click();
                }
                else
                {
                    throw new Exception("Пользователь авторизован");
                }
            });
        }
        // Открыть страницу логина 
        public void GetLoginPage()
        {
            bool userIsAuthorize = UserIsAuthorize();
            _exceptionHandler.HandleException(() =>
            {
                if (userIsAuthorize == false)
                {
                    WaitHelperPage.WaitUntilEelementIsClickable(browser, _logInButton, 10);
                    _logInButton.Click();
                }
                else
                {
                    throw new Exception("Пользователь авторизован");
                }
            });
        }
        // Выйти из аккаунт 
        public void LogOutFromPage()
        {
            bool userIsAuthorize = UserIsAuthorize();
            _exceptionHandler.HandleException(() =>
            {
                if (userIsAuthorize == true )
                {
                    WaitHelperPage.WaitUntilEelementIsClickable(browser, _logOutButton, 10);
                    _logInButton.Click();
                }
                else
                {
                    throw new Exception("Пользователь не авторизован");
                }
            });
        }
        // Переход на страницу управления профиля пользователя 
        public void GetManageProfilePage() 
        {
            _exceptionHandler.HandleException(() =>
            {
                if (UserIsAuthorize() == true)
                {
                    WaitHelperPage.WaitUntilEelementIsClickable(browser, _profileNameButton, 10);
                    _profileNameButton.Click();
                }
                else
                {
                    throw new Exception("Пользователь не авторизован");
                }
            });
        }
        public string GetFotterText() 
        {
            WaitHelperPage.WaitUntilElementIsVisable(browser, _footter, 10);
            string foterText = string.Empty;
            _exceptionHandler.HandleException(() =>
            {
                foterText = _footter.Text.Trim();
            });
            return foterText;
        }

    }
}
