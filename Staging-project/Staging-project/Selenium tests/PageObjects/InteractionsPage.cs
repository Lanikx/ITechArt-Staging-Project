using OpenQA.Selenium;
using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class InteractionsPage : BasePage
    {
        public string URL = "https://demoqa.com/interaction";


        public InteractionsPage(IWebDriver driver) : base(driver)
        { 
        }


    }
}