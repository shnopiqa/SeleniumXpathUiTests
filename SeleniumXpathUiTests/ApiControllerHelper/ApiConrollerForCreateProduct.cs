using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.ApiControllerHelper
{
    public class ApiConrollerForCreateProduct
    {
       public void CreateUser(ProductVM product) 
        {
            using(var client = new HttpClient()) 
            {
                client.BaseAddress = new Uri("https://localhost:7217/");
                var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
                var result = client.PostAsync("Product/Upsert", content).Result;
            }
        }
    }
}
