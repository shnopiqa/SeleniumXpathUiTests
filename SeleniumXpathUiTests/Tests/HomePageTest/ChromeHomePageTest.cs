using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.Tests.BaseTests;

namespace SeleniumXpathUiTests.Tests.HomePageTest
{
    public class ChromeHomePageTest : BaseTest
    {
        private const string URL = "https://google.com/";
        public ChromeHomePageTest() : base(BrowsersTypes.Chrome)
        {

        }
        [Fact]
        public void TrySomeTest()
        {
            InitalizeBasePage();
     
        }
    }
}
