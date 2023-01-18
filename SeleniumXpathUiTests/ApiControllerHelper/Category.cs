using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Xunit.Sdk;

namespace SeleniumXpathUiTests.ApiControllerHelper
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}