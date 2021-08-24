using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    class WebTables : BasePage
    {
        IWebElement addButton;

        readonly string submitXPath = "//button[@id = 'submit']";

        public WebTables(IWebDriver driver) : base(driver, "https://demoqa.com/webtables") { }


        public WebTables PressAddButton()
        {
            addButton = driver.FindElement(By.Id("addNewRecordButton"));
            addButton.Click();
            return this;
        }

        public WebTables PressSubmitButton()
        {
            driver.FindElement(By.XPath(submitXPath)).Click();
            return this;
        }
    }
}
