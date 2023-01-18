using SeleniumXpathUiTests.ApiControllerHelper;
using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.LoggerHelper;
using SeleniumXpathUiTests.Tests.BaseTests;
using SeleniumXpathUiTests.Tests.WebConstants;
using System.Diagnostics;

namespace SeleniumXpathUiTests.Tests.HomePageTest
{
    public class ChromeHomePageTest : BaseTest
    {
        ApiConrollerForCreateProduct apiController { get; set; }
        public ChromeHomePageTest() : base(BrowsersTypes.Chrome)
        {
            apiController = new ApiConrollerForCreateProduct();
        }
        [Fact]
        public void ProductNameDisplayedOnFirstCardTest() 
        {
            ProductVM productVM = new ProductVM()
            {
                Name = "Test",
                Description = "some disc",
                Price = 3.4,
                Image = "C:\\Users\\dokto\\OneDrive\\Рабочий стол\\6amzee.gif",
                CategoryId = 6,
                AppTypeId = 3
            };
            apiController.CreateUser(productVM);
            string expectedProductName = "321";
            Logger.Info("Переход на главную страницу");
            _basePage.GoToPageUrl(WC.BaseURL);
            Logger.Info("Инициализации главной страницы"); 
            var product = _homePage.InitializeFirstOrDefaultProductCard();
            Assert.Equal(expectedProductName, product.Name);
        }
    }
}
