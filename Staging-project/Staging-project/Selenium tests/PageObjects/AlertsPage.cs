using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Staging_project.Selenium_tests.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    public class AlertsPage : AlertsFramesWindowsPageGroup
    {
        public const string URL = "https://demoqa.com/alerts";

        
        private IWebElement alertButton 
        { 
            get 
            {
                return driver.FindElement(By.XPath("//*[@class = 'col']/button[@id = 'alertButton']"));    
            } 
        }

       
        private IWebElement delayAlertButton
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@class = 'col']/button[@id = 'timerAlertButton']"));
            }
        }
       
        private IWebElement confirmAlertButton
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@class = 'col']/button[@id = 'confirmButton']"));
            }
        }
        
        private IWebElement promptBoxButton
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@class = 'col']/button[@id = 'promtButton']"));
            }
        }
        
        private IWebElement promptResult
        {
            get
            {
                return driver.FindElement(By.Id("promptResult"));
            }
        }

        private IAlert alert;

        public AlertsPage(IWebDriver driver) : base(driver)
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
