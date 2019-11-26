using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace IVector.Common
{
    public class FirefoxWebDriver
    {
        public static IWebDriver LoadFirefoxDriver()
        {
            var driverService = FirefoxDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var options = new FirefoxOptions();
            options.AddArgument("--disable-extensions");
            return new FirefoxDriver(driverService, options);
        }
    }
}
