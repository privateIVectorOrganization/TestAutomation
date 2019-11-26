using IVector.Common;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace IVector.App
{

    public class LoginPage : BaseDriver
    {
        [FindsBy(How = How.Id, Using = "input#txtEmail")]
        IWebElement emailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "input#txtPassword")]
        IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "input#btnLogin")]
        IWebElement loginButton { get; set; }

        public LoginPage(BaseDriver baseDriver)
        {
            Driver = baseDriver;
            PageFactory.InitElements(Driver.Driver, this);
        }

        public void OpenSite(string url)
        {
            Driver.NavigateToUrl(url);
        }

        public void Login(string username, string psw)
        {
            emailAddress.Clear();
            emailAddress.SendKeys(username);
            password.SendKeys(psw);
            loginButton.Click();
        }
    }
}
