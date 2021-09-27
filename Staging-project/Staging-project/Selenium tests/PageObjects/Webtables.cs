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

        [FindsBy(How = How.Id, Using = "addNewRecordButton")]
        private IWebElement addButton;
        [FindsBy(How = How.XPath, Using = "//button[@id = 'submit']")]
        private IWebElement submitButton;

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
