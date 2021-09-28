using NUnit.Framework;
using Staging_project.PageObjects;
using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtAlertsPage
    {
        AlertsPage atPage;

        public AtAlertsPage(AlertsPage alertsPage)
        {
            atPage = alertsPage;
        }


        public void confirmAtAlertsFramesPage()
        {
            Assert.That(atPage.IsOnPage(AlertsPage.URL));
        }



        internal void InputAlert(string input)
        {
            atPage.AlertEnter(input);
            atPage.AlertAccept();
        }

        internal void AssertAlertInput(string result)
        {
            Assert.That(atPage.GetPromptResult() == result);
        }
    }
}