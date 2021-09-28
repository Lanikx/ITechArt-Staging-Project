using OpenQA.Selenium;
using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class WidgetsPage : BasePage
    {
        public string URL = "https://demoqa.com/widgets";



        public WidgetsPage(IWebDriver driver) : base(driver)
        {


        }
    }
}