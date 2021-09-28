using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtMainPage
    {
        MainPage atPage;

        public AtMainPage(MainPage mainPage)
        {
            this.atPage = mainPage;
        }


        public void GoToElementsPage()
        {
            atPage.CloseAd();
            atPage.ClickElementsButton();

        }


        public void GoToFormsPage()
        {
            atPage.CloseAd();
            atPage.ClickFormsButton();
        }


        public void GoToAlertsFramesWindowsPage()
        {
            atPage.CloseAd();
            atPage.ClickAlertsFrameWindowsButton();
        }

        public void GoToWidgetsPage()
        {
            atPage.CloseAd();
            atPage.ClickWidgetsButton();
        }

        public void GoToInteractionsPage()
        {
            atPage.CloseAd();
            atPage.ClickInteractionsButton();
        }

        public void GoToBookStorePage()
        {
            atPage.ScrollPageDown();
            atPage.CloseAd();
            atPage.ClickBookStoreButton();
        }

        public void ConfirmAtMainPage()
        {
            Assert.That(atPage.IsOnPage(MainPage.URL));
        }
    }
}