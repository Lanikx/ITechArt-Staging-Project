using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Staging_project.PageObjects
{
    class LoginPage : BasePage
    {
        public const string URL = "https://demoqa.com/login";


        [FindsBy(How = How.Id, Using = "userName")]
        private IWebElement userName
        {
            get
            {
                return driver.FindElement(By.Id("userName"));
            }
        }
        
        private IWebElement password
        {
            get
            {
                return driver.FindElement(By.Id("password"));
            }
        }
        
        private IWebElement login
        {
            get
            {
                return driver.FindElement(By.Id("login"));
            }
        }


        public LoginPage(IWebDriver driver) : base(driver, URL) { }


        public void EnterPassword(string password)
        {
            this.password.SendKeys(password);
        }

        public void EnterUserName(string userName)
        {
            this.userName.SendKeys(userName);
        }


        public void PressLogin()
        {
            login.Click();
        }


    }
}
