using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    class AlertsPage: BasePage
    {
        public const string URL = "https://demoqa.com/alerts";

        [FindsBy(How = How.XPath, Using = "//*[@class = 'col']/button[@id = 'alertButton']")]
        private IWebElement alertButton;
        [FindsBy(How = How.XPath, Using = "//*[@class = 'col']/button[@id = 'timerAlertButton']")]
        private IWebElement delayAlertButton;
        [FindsBy(How = How.XPath, Using = "//*[@class = 'col']/button[@id = 'confirmButton']")]
        private IWebElement confirmAlertButton;
        [FindsBy(How = How.XPath, Using = "//*[@class = 'col']/button[@id = 'promtButton']")]
        private IWebElement promptBoxButton;
        [FindsBy(How = How.XPath, Using = "//span[@id = 'promptResult']")]
        private IWebElement promptResult;
        
        private IAlert alert;

        public AlertsPage(IWebDriver driver) : base(driver, URL)
        {
           
        }


        public void AlertButtonClick()
        {
                alertButton.Click();
        }

        public void DelayAlertButtonClick()
        {
                delayAlertButton.Click();
        }

        public void ConfirmAlertButtonClick()
        {
                confirmAlertButton.Click();
        }
        
        public void PromptBoxButtonClick()
        {
                promptBoxButton.Click();
        }
        


        public string GetPromptResult()
        {
            return promptResult.Text;
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
