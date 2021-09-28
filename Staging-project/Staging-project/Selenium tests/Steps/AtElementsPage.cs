using NUnit.Framework;
using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtElementsPage
    {
        ElementsPage atPage;

        public AtElementsPage(ElementsPage page)
        {
            atPage = page;
        }


        public void ConfirmAtElementsPage()
        {
            Assert.That(atPage.IsOnPage(atPage.URL));
        }

        internal void GoToTextBoxPage()
        {
            atPage.ClickTextBoxButton();
        }

        internal void GoToWebTablesPage()
        {
            atPage.ClickWebTablesButton();
        }
    }
}