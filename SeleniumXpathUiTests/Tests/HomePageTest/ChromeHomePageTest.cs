using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.Tests.BaseTests;

namespace SeleniumXpathUiTests.Tests.HomePageTest
{
    public class ChromeHomePageTest : BaseTest
    {
        private const string URL = "https://localhost:7217/";
        public ChromeHomePageTest() : base(BrowsersTypes.Chrome)
        {

        }
        [Fact]
        public void TrySomeTest()
        {
            InitalizeBasePage();
            InitalizeHomePage();
            _basePage.GoToPageUrl(URL);
            var Page = _homePage.InitializeFirstOrDefaultProductCard();
     
        }
    }
}
