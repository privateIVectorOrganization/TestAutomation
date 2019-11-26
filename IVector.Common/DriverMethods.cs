using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IVector.Common
{
    public class DriverMethods
    {
        public IWebDriver Driver;

        public void InitializeDrive(BrowserTypes browserType)
        {
            if (!IsDriverExist())
            {
                switch (browserType)
                {
                    case BrowserTypes.CHROME:
                        Driver = ChromeWebDriver.LoadChromeDriver();
                        Driver.Manage().Window.FullScreen();
                        break;
                    case BrowserTypes.FIREFOX:
                        Driver = FirefoxWebDriver.LoadFirefoxDriver();
                        Driver.Manage().Window.FullScreen();
                        break;
                    default:
                        string message = "Invalid browser type!";
                        throw new Exception(message);
                }
            }
        }

        public void SetImplicitWait(double second)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(second);
        }

        public void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void RefhreshPage()
        {
            Driver.Navigate().Refresh();
        }

        public void ClickOnForwardButton()
        {
            Driver.Navigate().Forward();
        }
        public void ClickOnBackButton()
        {
            Driver.Navigate().Back();
        }

        public void CloseDriver()
        {
            if (IsDriverExist())
            {
                Driver.Dispose();
                Driver.Quit();
                Driver = null;
            }
        }

        private bool IsDriverExist()
        {
            return Driver != null;
        }

        public static implicit operator DriverMethods(BaseDriver v)
        {
            throw new NotImplementedException();
        }
    }
}
