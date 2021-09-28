namespace Staging_project.Selenium_tests.Steps
{
    public class AtInteractionsPage
    {
        InteractionsPage atPage;

        public AtInteractionsPage(InteractionsPage interactionsPage)
        {
            this.atPage = interactionsPage;
        }


        public void ConfirmAtInteractionsPage()
        {
            Assert.That(atPage.IsOnPage(atPage.URL));
        }
    }
}