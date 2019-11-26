using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IVector.Common
{
    public class ChromeWebDriver
    {
        public static IWebDriver LoadChromeDriver()
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            options.AddArgument("--disable-extensions");
            return new ChromeDriver();
        }

    }
}
