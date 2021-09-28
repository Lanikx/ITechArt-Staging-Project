using NUnit.Framework;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtBookStorePage
    {
         readonly string Url = "https://demoqa.com/books";

        BookStorePage atPage;

        public AtBookStorePage(BookStorePage page)
        {
            atPage = page;
        }


        public void goToLoginPage()
        {
            atPage.ClickLoginButton();

        }

        public void ConfirmAtBookStorePage()
        {
            Assert.That(atPage.IsOnPage(BookStorePage.URL));
        }
    }
}