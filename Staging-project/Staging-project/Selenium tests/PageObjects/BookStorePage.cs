using OpenQA.Selenium;
using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class BookStorePage : BasePage
    {
        public string URL = "https://demoqa.com/books";


        public BookStorePage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement loginButton
        {
            get
            {
                return driver.FindElement(By.XPath("//li/span[text() = 'Login']/.."));
            }
        }

        private string loginButtonId = "item-0";

        public void ClickLoginPage()
        {
            loginButton.Click();

        }
    }
}