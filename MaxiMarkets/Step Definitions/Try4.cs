using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
            System.Threading.Thread.Sleep(4000);


            //ScenarioContext.Current.Pending();
        }

        [When(@"I input '(.*)' in e-mail field")]
        public void WhenIInputInE_MailField(string p0)
        {
            int N = 1;
            int[] a = new int[N];

            Random random = new Random();
            int rand;
            for (int i = 0; i < N; i++)
            {
                rand = random.Next(100, 999);
                a[i] = rand;
                IWebElement Log = driver.FindElement(By.Id("email"));
                Log.SendKeys(rand + "def@mail.ru");
            }
            //ScenarioContext.Current.Pending();
        }

        [When(@"I input '(.*)' in password field")]
        public void WhenIInputInPasswordField(string p0)
        {
            IWebElement Log = driver.FindElement(By.Id("password"));
            Log.SendKeys("qwerty12345");
            //ScenarioContext.Current.Pending();
        }

        [When(@"I input '(.*)' in confirm-password field")]
        public void WhenIInputInConfirm_PasswordField(string p0)
        {
            //IWebElement Log = driver.FindElement(By.Id("confirm"));
            //Log.SendKeys("qwerty12345");

            IWebElement Pass = driver.FindElement(By.Id("confirm"));
            Pass.SendKeys("qwerty12345" + OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(3000);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I click on button Submit")]
        public void WhenIClickOnButtonSubmit()
        {
            //IWebElement SignOut;
            //SignOut = driver.FindElement(By.ClassName("btn btn-success"));
            //SignOut.Click();
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Link '(.*)' is displayed")]
        public void ThenLinkIsDisplayed(string p0)
        {
            IWebElement SignOut;
            SignOut = driver.FindElement(By.LinkText("Выйти"));
            SignOut.Click();
            driver.Quit();
            //ScenarioContext.Current.Pending();
        }
    }
}
