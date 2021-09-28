using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    class WebTables : BasePage
    {
        public const string URL = "https://demoqa.com/webtables";

        private IWebElement addButton
        {
            get
            {
                return driver.FindElement(By.Id("addNewRecordButton"));
            }
        }

        private IWebElement submitButton
        {
            get
            {
                return driver.FindElement(By.XPath("//button[@id = 'submit']"));
            }
        }

        public WebTables(IWebDriver driver) : base(driver, URL) { }


        public void PressAddButton()
        {
            addButton.Click();
        }

        public void PressSubmitButton()
        {
            submitButton.Click();
        }
    }
}
