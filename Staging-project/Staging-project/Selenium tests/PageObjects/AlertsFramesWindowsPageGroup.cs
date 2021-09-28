using OpenQA.Selenium;
using Staging_project.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.Selenium_tests.PageObjects
{
    public abstract class AlertsFramesWindowsPageGroup : BasePage
    {

        protected IWebElement browserWindowsButton { get { return driver.FindElement(By.XPath("//span[text() = 'Browser Windows']")); } }

        protected IWebElement alertsButton { get { return driver.FindElement(By.XPath("//span[text() = 'Alerts']")); } }

        protected IWebElement framesButton { get { return driver.FindElement(By.XPath("//span[text() = 'Frames']")); } }

        protected IWebElement nestedFramesButton { get { return driver.FindElement(By.XPath("//span[text() = 'Nested Frames']")); } }

        protected IWebElement modalDialogsButton { get { return driver.FindElement(By.XPath("//span[text() = 'Modal Dialogs']")); } }

        public AlertsFramesWindowsPageGroup(IWebDriver driver) :base(driver)
        { }

        public void ClickBrowserWindowsButton()
        {
            browserWindowsButton.Click();
        }

        public void ClickAlertsButton()
        {
            alertsButton.Click();
        }

        public void ClickFramesButton()
        {
            framesButton.Click();
        }

        public void ClickNestedFragmentsButton()
        {
            nestedFramesButton.Click();
        }

        public void ClickModalDialogsButton()
        {
            modalDialogsButton.Click();
        }
    }
}
