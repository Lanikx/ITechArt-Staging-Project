using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Staging_project.PageObjects
{
    class LoginPage : BasePage
    {
        public const string URL = "https://demoqa.com/login";


        [FindsBy(How = How.Id, Using = "userName")]
        private IWebElement userName;
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;
        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement login;


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
