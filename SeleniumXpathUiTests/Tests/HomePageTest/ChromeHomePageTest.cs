using SeleniumXpathUiTests.BrowserHelpers.BrowserTypes;
using SeleniumXpathUiTests.PageObject.BasePageObject;
using SeleniumXpathUiTests.Tests.BaseTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
