using Staging_project.PageObjects;
using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtWebTablesPage
    {
        private WebTablesPage atPage;

        public AtWebTablesPage(WebTablesPage page)
        {
            atPage = page;
        }

        internal void Add()
        {
            atPage.PressAddButton();
        }

        internal void Submit()
        {
            atPage.PressSubmitButton();
        }

        internal void AssertAddFailed()
        {
            atPage.IsSomethingInvalid();
        }
    }
}