
using SeleniumXpathUiTests.LoggerHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.Tests.Helpers
{
    public class ExceptionHandler
    {
        public void HandleException(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {

                Logger.Info($"Exception message: {ex}");
                throw;
            }
        }
    }
}
