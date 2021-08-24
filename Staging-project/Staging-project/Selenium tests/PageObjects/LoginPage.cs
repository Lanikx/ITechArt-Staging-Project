using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    class LoginPage : BasePage
    {

        IWebElement userName;
        IWebElement password;
        IWebElement login;


        public LoginPage(IWebDriver driver) : base(driver, "https://demoqa.com/login") { }


        public LoginPage Login(string userName, string password)
        {
            if (IsOnPage("https://demoqa.com/login"))
            {
                EnterPassword(password);
                EnterUserName(userName);
            }
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            if (IsOnPage("https://demoqa.com/login"))
            {
                this.password = driver.FindElement(By.Id("password"));
                this.password.SendKeys(password);
            }
            return this;
        }

        public LoginPage EnterUserName(string userName)
        {
            if (IsOnPage("https://demoqa.com/login"))
            {
                this.userName = driver.FindElement(By.Id("userName"));
                this.userName.SendKeys(userName);
            }
            return this;
        }
       

        public LoginPage PressLogin()
        {
            this.login = driver.FindElement(By.Id("login"));
            if (IsOnPage("https://demoqa.com/login"))
            {
                login.Click();
            }
            return this;
        }

       
    }
}
