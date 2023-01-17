using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.LoggerHelper;
using SeleniumXpathUiTests.Tests.BaseTests;
using SeleniumXpathUiTests.Tests.WebConstants;

namespace SeleniumXpathUiTests.Tests.HomePageTest
{
    public class ChromeHomePageTest : BaseTest
    {
        public ChromeHomePageTest() : base(BrowsersTypes.Chrome)
        {

        }
        [Fact]
        public void GetShopinCartPageTest()
        {
            InitalizeBasePage();
            Logger.Info("Инициализация базовой страницы");
            // Обертка над try/catch 
            _exceptionHandler.HandleException(() =>
            {
                InitalizeHomePage();
                Logger.Info("Инициализация страницы Home");
                _basePage.GoToPageUrl(WC.BaseURL);
                Logger.Info($"Переход на главную страницу по ссылке {WC.BaseURL}");
                _basePage.GetShopingCartPage();
                Logger.Info("Переход на страницу корзины");
            });
        }
        [Fact]
        public void GetRegistPageTest()
        {
            InitalizeBasePage();
            Logger.Info("Инициализация базовой страницы");
            // Обертка над try/catch 
            _exceptionHandler.HandleException(() =>
            {
                InitalizeHomePage();
                Logger.Info("Инициализация страницы Home");
                _basePage.GoToPageUrl(WC.BaseURL);
                Logger.Info($"Переход на главную страницу по ссылке {WC.BaseURL}");
                _basePage.GetRegisterPage();
                Logger.Info("Переход на страницу регистрации");
            });
        }
        [Fact]
        public void GetLoginPageTest()
        {
            InitalizeBasePage();
            Logger.Info("Инициализация базовой страницы");
            // Обертка над try/catch 
            _exceptionHandler.HandleException(() =>
            {
                InitalizeHomePage();
                Logger.Info("Инициализация страницы Home");
                _basePage.GoToPageUrl(WC.BaseURL);
                Logger.Info($"Переход на главную страницу по ссылке {WC.BaseURL}");
                _basePage.GetLoginPage();
                Logger.Info("Переход на страницу регистрации");
            });
        }
    }
}
