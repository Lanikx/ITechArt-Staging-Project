using OpenQA.Selenium;
using Staging_project.Selenium_tests.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class FormsPage : FormsPageGroup
    {
        public static string URL = "https://demoqa.com/forms";

        public FormsPage(IWebDriver driver) : base(driver)
        {

        }

    }
}