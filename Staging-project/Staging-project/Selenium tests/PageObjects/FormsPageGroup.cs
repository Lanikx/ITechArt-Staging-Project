using OpenQA.Selenium;
using Staging_project.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.Selenium_tests.PageObjects
{
    public abstract class FormsPageGroup : BasePage
    {
        protected IWebElement practiceFormButton { get { return driver.FindElement(By.XPath("//span[text() = 'Practice Form']")); } }
        
        public FormsPageGroup(IWebDriver driver) : base(driver){ }

        public void ClickPracticeFormButton() { practiceFormButton.Click(); }
    }
}
