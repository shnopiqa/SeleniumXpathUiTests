using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.Tests.WebConstants
{
    public class WC
    {
        public const string BaseURL = "https://localhost:7217/";
        public const string CategoryURL = $"{BaseURL}Category";
        public const string ApplicationTypeURL = $"{BaseURL}ApplicationType";
        public const string ProductPageURL = $"{BaseURL}Product";
        public const string CreateAdminUserURL = $"{BaseURL}Identity/Account/Register";
        public const string ManageAccounURL = $"{BaseURL}Identity/Account/Manage"; 

    }
}
