using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MaxiMarkets
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
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email")));


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

        [When(@"I click on button '(.*)'")]
        public void WhenIClickOnButtonConfirm(string p0)
        {
            IWebElement Log = driver.FindElement(By.Id("confirm"));
            Log.SendKeys("qwerty12345");
            //ScenarioContext.Current.Pending();
        }


        [When(@"Link '(.*)' is displayed")]
        public void ButtonSubmit(string p0)
        {
            IWebElement SignOut;
            SignOut = driver.FindElement(By.LinkText("Отправить"));
            SignOut.Click();
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Link '(.*)' is displayed")]
        public void ThenLinkIsDisplayed(string p0)
        {
            IWebElement SignOut;
            SignOut = driver.FindElement(By.LinkText("Выйти"));
            SignOut.Click();
            //ScenarioContext.Current.Pending();
        }
    }
}

