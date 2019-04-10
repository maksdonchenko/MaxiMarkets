using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MaxiMarkets.Step_Definitions
{
    ChromeDriver Tirfac;

    [Binding]
    public class RegistrationPageSteps
    {
        [Given(@"MyAccount page '(.*)' is opened")]
        public void GivenMyAccountPageIsOpened(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I input '(.*)' in e-mail field")]
        public void WhenIInputInE_MailField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I input '(.*)' in password field")]
        public void WhenIInputInPasswordField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I input '(.*)' in confirm-password field")]
        public void WhenIInputInConfirm_PasswordField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on button Submit")]
        public void WhenIClickOnButtonSubmit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Link '(.*)' is displayed")]
        public void ThenLinkIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
