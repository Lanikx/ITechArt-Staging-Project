using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    class AlertsPage: BasePage
    {

        private IWebElement alertButton;

        private IWebElement delayAlertButton;

        private IWebElement confirmAlertButton;

        private IWebElement promptBoxButton;

        private IAlert alert;

        public AlertsPage(IWebDriver driver) : base(driver, "https://demoqa.com/alerts")
        {
           
        }


        public void AlertButtonClick()
        {
            alertButton = driver.FindElement(By.XPath("//*[@class = 'col']/button[@id = 'alertButton']"));
            if (IsOnPage("https://demoqa.com/alerts"))
                alertButton.Click();
        }

        public void DelayAlertButtonClick()
        {
            delayAlertButton = driver.FindElement(By.XPath("//*[@class = 'col']/button[@id = 'timerAlertButton']"));
            if (IsOnPage("https://demoqa.com/alerts"))
                delayAlertButton.Click();
        }

        public void ConfirmAlertButtonClick()
        {
            confirmAlertButton = driver.FindElement(By.XPath("//*[@class = 'col']/button[@id = 'confirmButton']"));
            if (IsOnPage("https://demoqa.com/alerts"))
                confirmAlertButton.Click();
        }
        
        public void PromptBoxButtonClick()
        {
            promptBoxButton = driver.FindElement(By.XPath("//*[@class = 'col']/button[@id = 'promtButton']"));
            if (IsOnPage("https://demoqa.com/alerts"))
                promptBoxButton.Click();
        }
        


        public string GetPromptResult()
        {
            return driver.FindElement(By.XPath("//span[@id = 'promptResult']")).Text;
        }

        public void AlertAccept()
        {
            alert = driver.SwitchTo().Alert();
            alert.Accept();
            alert = null;
        }
            
        public void AlertEnter(string enter)
        {
            alert = driver.SwitchTo().Alert();
            if(alert != null)
            alert.SendKeys(enter);
           
        }
         
        public void AlertDismiss()
        {
            alert = driver.SwitchTo().Alert();
            alert.Dismiss();
            alert = null;
        }
    }
}
