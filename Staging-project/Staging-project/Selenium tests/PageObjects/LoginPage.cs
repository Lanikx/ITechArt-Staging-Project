using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Staging_project.Selenium_tests.PageObjects;

namespace Staging_project.PageObjects
{
    public class LoginPage : BookStoreApplicationPageGroup
    {
        public const string URL = "https://demoqa.com/login";


        
        private IWebElement userName
        {
            get
            {
                return driver.FindElement(By.CssSelector("#userName.mr-sm-2.form-control"));
            }
        }
        
        private IWebElement password
        {
            get
            {
                return driver.FindElement(By.CssSelector("#password.mr-sm-2.form-control"));
            }
        }
        
        private IWebElement login
        {
            get
            {
                return driver.FindElement(By.Id("login"));
            }
        }


        public LoginPage(IWebDriver driver) : base(driver) { }


        public void EnterPassword(string password)
        {
            this.password.SendKeys(password);
        }

        public void EnterUserName(string userName)
        {
            this.userName.SendKeys(userName);
        }


        public void PressLoginButton()
        {
            login.Click();
        }

        public bool FailedFieldExists()
        {
           return this.IsSomethingInvalid();
        }

    }
}
