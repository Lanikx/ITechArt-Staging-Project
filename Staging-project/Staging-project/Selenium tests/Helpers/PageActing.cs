using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Staging_project.Helpers
{
    class PageActing
    {
        static public void ScrollDown(IWebDriver driver)
        {
            var element = driver.FindElement(By.Id("botton-text-10"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        static public void CloseAd(IWebDriver driver)
        {
            var ad = driver.FindElement(By.Id("close-fixedban"));
            if (ad != null)
            ad.Click();
        }

        public static IWebElement WaitForElement(By by, IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            return element;
        }

        public static bool ElementExists(By by, IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            if (element != null)
                return true;
            return false;
        }

        public static bool AlertExists(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            if (element != null)
                return true;
            return false;
        }
    }
}
