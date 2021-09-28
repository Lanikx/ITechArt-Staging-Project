using OpenQA.Selenium;
using Staging_project.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.Selenium_tests.PageObjects
{
    public abstract class AlertsFramesWindowsPageGroup : BasePage
    {

        protected IWebElement BrowserWindowsButton { get { return driver.FindElement(By.XPath("//span[text() = 'Browser Windows']")); } }

        protected IWebElement AlertsButton { get { return driver.FindElement(By.XPath("//span[text() = 'Alerts']")); } }

        protected IWebElement FramesButton { get { return driver.FindElement(By.XPath("//span[text() = 'Frames']")); } }

        protected IWebElement NestedFramesButton { get { return driver.FindElement(By.XPath("//span[text() = 'Nested Frames']")); } }

        protected IWebElement ModalDialogsButton { get { return driver.FindElement(By.XPath("//span[text() = 'Modal Dialogs']")); } }

        public AlertsFramesWindowsPageGroup(IWebDriver driver) :base(driver)
        { }

        public void ClickBrowserWindowsButton()
        {
            BrowserWindowsButton.Click();
        }

        public void ClickAlertsButton()
        {
            AlertsButton.Click();
        }

        public void ClickFramesButton()
        {
            FramesButton.Click();
        }

        public void ClickNestedFragmentsButton()
        {
            NestedFramesButton.Click();
        }

        public void ClickModalDialogsButton()
        {
            ModalDialogsButton.Click();
        }
    }
}
