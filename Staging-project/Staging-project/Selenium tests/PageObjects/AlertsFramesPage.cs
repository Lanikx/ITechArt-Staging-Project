using OpenQA.Selenium;
using Staging_project.PageObjects;
using Staging_project.Selenium_tests.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class AlertsFramesPage : AlertsFramesWindowsPageGroup
    {
        public static string URL = "https://demoqa.com/alertsWindows";

        public AlertsFramesPage(IWebDriver driver) : base(driver)
        {

        }



    }
}