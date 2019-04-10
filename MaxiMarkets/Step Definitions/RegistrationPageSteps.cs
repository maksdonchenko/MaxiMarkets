using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace MaxiMarkets.Step_Definitions
{

    [Binding]
    public class RegistrationPageSteps
    {
        ChromeDriver driver;

        [Given(@"MyAccount page '(.*)' is opened")]
        public void GivenMyAccountPageIsOpened(string p0)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://test-myaccount.maximarkets.org/?lang=ru#register");
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I input '(.*)' in '(.*)' field")]
        public void WhenIInputInField(string p0, string p1)
        {
            IWebElement Log = driver.FindElement(By.Id("email"));
            Log.SendKeys("keke@mail.ru");
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on button '(.*)'")]
        public void WhenIClickOnButton(string p0)
        {
            IWebElement Log = driver.FindElement(By.Id("password"));
            Log.SendKeys("qwerty12345");
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on '(.*)' link")]
        public void WhenIClickOnLink(string p0)
        {
            IWebElement Log = driver.FindElement(By.Id("confirm"));
            Log.SendKeys("qwerty12345");
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I input ''(.*)'e-mail' field")]
        public void WhenIInputE_MailField(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Personal page opened")]
        public void ThenPersonalPageOpened()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"Link '(.*)' is displayed")]
        public void ThenLinkIsDisplayed(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Native mail client is opened")]
        public void ThenNativeMailClientIsOpened()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Error message '(.*)' is displayed near field '(.*)'")]
        public void ThenErrorMessageIsDisplayedNearField(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
