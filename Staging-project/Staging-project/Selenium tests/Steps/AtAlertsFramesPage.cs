using NUnit.Framework;
using Staging_project.PageObjects;
using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtAlertsFramesPage 
    {
        AlertsFramesPage atPage;

        public AtAlertsFramesPage(AlertsFramesPage alertsFramesPage)
        {
            atPage = alertsFramesPage;
        }


        public void confirmAtAlertsFramesPage()
        {
            Assert.That(atPage.IsOnPage(AlertsFramesPage.URL));
        }

        public void GoToAlertsPage()
        {
            atPage.ClickAlertsButton();
        }
    }
}