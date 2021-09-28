using OpenQA.Selenium;
using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    internal class ElementsPage :BasePage
    {
        public string URL = "https://demoqa.com/elements";



        public ElementsPage(IWebDriver driver) : base (driver)
        {

        }
    }
}