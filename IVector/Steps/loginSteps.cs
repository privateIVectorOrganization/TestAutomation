using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using IVector.App;

namespace IVector.Test.Steps
{
    [Binding]
    public class loginSteps
    {
        public LoginPage loginpage;

        [Given(@"User is at '(.*)' page")]
        public void GivenUserIsAtPage(string url)
        {
            loginpage.OpenSite(url);
        }

        [When(@"User enter '(.*)' and '(.*)'")]
        public void WhenUserEnterAnd(string userName, string password)
        {
            loginpage.Login(userName, password);
        }

        [Then(@"User wait")]
        public void ThenUserWait()
        {
            //ScenarioContext.Current.Pending();
            loginpage.Login("fdgdfg", "gfdgdf");
        }

    }
}
