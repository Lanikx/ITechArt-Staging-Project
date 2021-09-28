using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtFormsPage
    {
        FormsPage atPage;

        public AtFormsPage(FormsPage formsPage)
        {
            this.atPage = formsPage;
        }


        public void ConfirmAtFormsPage()
        {
            Assert.That( atPage.IsOnPage(atPage.URL));
        }

        internal void GoToPracticeFormPage()
        {
            throw new NotImplementedException();
        }
    }
}