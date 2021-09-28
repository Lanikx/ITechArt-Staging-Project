using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    public class MainPage : BasePage
    {
        public static readonly string URL = "https://demoqa.com/";


        private IWebElement elementsButton
        {
            get
            {
                return driver.FindElement(By.XPath("//h5[@text = 'Elements']"));
            }
        }

        private IWebElement formsButton
        {
            get
            {
                return driver.FindElement(By.XPath("//h5[@text = 'Forms']"));
            }
        }

        private IWebElement alertsFrameWindowsButton
        {
            get
            {
                return driver.FindElement(By.XPath("//h5[@text = 'Alerts, Frame & Windows']"));
            }
        }

        private IWebElement widgetsButton
        {
            get
            {
                return driver.FindElement(By.XPath("//h5[@text = 'Widgets']"));
            }
        }

        private IWebElement interactionsButton
        {
            get
            {
                return driver.FindElement(By.XPath("//h5[@text = 'Interactions']"));
            }
        }
       
        private IWebElement bookStoreButton
        {
            get
            {
                return driver.FindElement(By.XPath("//h5[@text = 'Book Store Application']"));
            }
        }

        public MainPage(IWebDriver driver) : base(driver, URL)
        {

        }


        
        public void ClickElementsButton()
        {
            elementsButton.Click();
        }

        public void ClickFormsButton()
        {
            formsButton.Click();
        }

        public void ClickAlertsFrameWindowsButton()
        {
            alertsFrameWindowsButton.Click();
        }

        public void ClickWidgetsButton()
        {
            widgetsButton.Click();
        }

        public void ClickInteractionsButton()
        {
            interactionsButton.Click();
        }

        public void ClickBookStoreButton()
        {
            bookStoreButton.Click();
        }


    }
}
