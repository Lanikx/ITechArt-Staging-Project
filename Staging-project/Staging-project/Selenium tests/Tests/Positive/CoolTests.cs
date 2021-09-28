using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using Staging_project.PageObjects;
using Staging_project.Selenium_tests.Helpers;

namespace Staging_project.Tests.Positive
{
    [Parallelizable(ParallelScope.All)]
    [AllureNUnit]
    class CoolTests : BaseTest
    {



        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void PromptBoxAlertTest()
        {
            user.atMainPage.GoToAlertsFramesWindowsPage();
            user.atAlertsFramesPage.GoToAlertsPage();
            user.atAlertsPage.InputAlert("Some kind of ghost");
            user.atAlertsPage.AssertAlertInput("You entered Some kind of ghost");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void TextBoxEnterTest()
        {
            user.atMainPage.GoToElementsPage();
            user.atElementsPage.GoToTextBoxPage();
            user.atTextBoxPage.SubmitData("", "");
            user.atTextBoxPage.AssertOutput("Name:Cockpit SergeevichEmail:ding@dong.com");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void PracticeFormTest()
        {
            user.atMainPage.GoToFormsPage();
            user.atFormsPage.GoToPracticeFormPage();
            user.atPracticeFormPage.EnterData("Nikita", "Lapin", Gender.Male, "0123456789");
            user.atPracticeFormPage.AssertModalContentExists();
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageElementsTest()
        {
            user.atMainPage.GoToElementsPage();
            user.atElementsPage.ConfirmAtElementsPage();
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageFormsTest()
        {
            user.atMainPage.GoToFormsPage();
            user.atFormsPage.ConfirmAtFormsPage();
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageAlertsFramesWindowsTest()
        {
            user.atMainPage.GoToAlertsFramesWindowsPage();
            user.atAlertsFramesPage.confirmAtAlertsFramesPage();
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageWidgetsTest()
        {
            user.atMainPage.GoToWidgetsPage();
            user.atWidgetsPage.ConfirmAtWidgetsPage();
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageInteractionsTest()
        {
            user.atMainPage.GoToInteractionsPage();
            user.atInteractionsPage.ConfirmAtInteractionsPage();
        }


        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageBookStoreTest()
        {
            user.atMainPage.GoToBookStorePage();
            user.atBookStorePage.ConfirmAtBookStorePage();
        }





    }
}
