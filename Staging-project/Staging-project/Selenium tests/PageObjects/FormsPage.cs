using OpenQA.Selenium;
using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
     class FormsPage : BasePage
    {
        public string URL = "https://demoqa.com/forms";



        public FormsPage(IWebDriver driver) : base(driver)
        {

        }
    }
}