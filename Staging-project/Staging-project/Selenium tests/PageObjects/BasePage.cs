using OpenQA.Selenium;
using Staging_project.Helpers;

namespace Staging_project.PageObjects
{
    class BasePage
    {
        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver, string pageUrl)
        {
            this.driver = driver;
            this.driver.Url = pageUrl;
            
        }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        void Click(IWebElement elem)
        {
            elem.Click();
        }


        public bool IsOnPage(string pageUrl)
        {
            if (driver.Url == pageUrl)
                return true;
            return false;
        }
    }
}
