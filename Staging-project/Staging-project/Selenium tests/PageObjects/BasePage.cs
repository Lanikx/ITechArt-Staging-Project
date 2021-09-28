using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Staging_project.Helpers;
using System;

namespace Staging_project.PageObjects
{
    public class BasePage
    { 
        protected  IWebDriver driver;

        internal bool IsSomethingInvalid()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".form-control.is-invalid, .was-validated .form-control:invalid"))) != null;
        }

        public void CloseAd()
        {
            var ad = driver.FindElements(By.Id("close-fixedban"))[0];
            if (ad != null)
                ad.Click();
        }

        public bool IsOnPage(string pageUrl)
        {
            return driver.Url.Equals(pageUrl);
        }
        internal void ScrollPageDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
