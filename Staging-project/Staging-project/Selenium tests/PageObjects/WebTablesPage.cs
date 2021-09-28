using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Staging_project.Selenium_tests.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    public class WebTablesPage : ElementsPageGroup
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

        public WebTablesPage(IWebDriver driver) : base(driver) { }


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
