using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.LoggerHelper;
using SeleniumXpathUiTests.Tests.BaseTests;
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
                _basePage.GoToPageUrl(URL);
                Logger.Info($"Переход на главную страницу по ссылке {URL}");
                _basePage.GetShopingCartPage();
                Logger.Info("Переход на страницу корзины");
            });
        }
    }
}
