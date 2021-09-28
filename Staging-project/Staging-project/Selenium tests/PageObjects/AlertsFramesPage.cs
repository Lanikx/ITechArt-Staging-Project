using OpenQA.Selenium;
using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class AlertsFramesPage : BasePage
    {
        public static string URL = "https://demoqa.com/alertsWindows";

        public AlertsFramesPage(IWebDriver driver) : base(driver)
        {

        }

    }
}