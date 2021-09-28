using OpenQA.Selenium;
using Staging_project.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.Selenium_tests.PageObjects
{
    public abstract class BookStoreApplicationPageGroup : BasePage
    {

        protected IWebElement loginButton { get { return driver.FindElement(By.XPath("//span[text() = 'Login']")); } }

        protected IWebElement bookStoreButton { get { return driver.FindElement(By.XPath("//span[text() = 'Book Store']")); } }

        protected IWebElement profileButton { get { return driver.FindElement(By.XPath("//span[text() = 'Profile']")); } }

        protected IWebElement bookStoreApiButton { get { return driver.FindElement(By.XPath("//span[text() = 'Book Store API']")); } }


        public BookStoreApplicationPageGroup(IWebDriver driver): base(driver) { }

        public void ClickLoginButton() { loginButton.Click(); }

        public void ClickBookStoreButton() { bookStoreButton.Click(); }

        public void ClickProfileButton() { profileButton.Click(); }

        public void ClickBookStoreApiButton() { bookStoreApiButton.Click(); }

    }
}
