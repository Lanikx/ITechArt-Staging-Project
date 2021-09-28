using NUnit.Framework;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtWidgetsPage
    {
        WidgetsPage atPage;

        public AtWidgetsPage(WidgetsPage widgetsPage)
        {

            this.atPage = widgetsPage;
        }


    public void ConfirmAtWidgetsPage()
        {
            Assert.That( atPage.IsOnPage(atPage.URL));
        }
    }
}