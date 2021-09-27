using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    class MainPage : BasePage
    {
        public const string URL = "https://demoqa.com/";

        [FindsBy(How =How.XPath, Using = "//h5[@text = 'Elements']")]
        private IWebElement elementsButton;
        [FindsBy(How = How.XPath, Using = "//h5[@text = 'Forms']")]
        private IWebElement formsButton;
        [FindsBy(How = How.XPath, Using = "//h5[@text = 'Alerts, Frame & Windows']")]
        private IWebElement alertsFrameWindowsButton;
        [FindsBy(How = How.XPath, Using = "//h5[@text = 'Widgets']")]
        private IWebElement widgetsButton;
        [FindsBy(How = How.XPath, Using = "//h5[@text = 'Interactions']")]
        private IWebElement interactionsButton;
        [FindsBy(How = How.XPath, Using = "//h5[@text = 'Book Store Application']")]
        private IWebElement bookStoreButton;

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
