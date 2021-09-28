using OpenQA.Selenium;
using Staging_project.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.Selenium_tests.PageObjects
{
    public abstract class ElementsPageGroup : BasePage
    {
        protected IWebElement textBoxButton { get { return driver.FindElement(By.XPath("//span[text() = 'Text Box']")); } }

        protected IWebElement webTablesButton { get { return driver.FindElement(By.XPath("//span[text() = 'Web Tables']")); } }

        public ElementsPageGroup(IWebDriver driver) : base(driver){ }

        public void ClickTextBoxButton() { textBoxButton.Click(); }

        public void ClickWebTablesButton()
        {
            webTablesButton.Click();
        }
    }
}
