using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using Staging_project.PageObjects;

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
            AlertsPage alertsPage = new AlertsPage(provider.driver);
            alertsPage.PromptBoxButtonClick();
            alertsPage.AlertEnter(data[0].ToString());
            alertsPage.AlertAccept();
            Assert.That(alertsPage.GetPromptResult() == data[1].ToString());
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void TextBoxEnterTest()
        {
            TextBoxPage textBoxPage = new TextBoxPage(provider.driver);
            textBoxPage.EnterName("Cockpit Sergeevich");
            textBoxPage.EnterEmail("ding@dong.com");
            textBoxPage.PressSubmit();
            Assert.That(textBoxPage.GetNameOutput() + textBoxPage.GetEmailOutput() == "Name:Cockpit SergeevichEmail:ding@dong.com");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void PracticeFormTest()
        {
            PracticeForm practiceForm = new PracticeForm(provider.driver);
            practiceForm.EnterName("Nikita");
            practiceForm.EnterLastName("Lapin");
            practiceForm.CheckMaleGender();
            practiceForm.EnterNumber("0123456789");
            practiceForm.PressSubmit();
            Assert.That(practiceForm.ModalContentExists());
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageElementsTest()
        {
            MainPage mainpage = new MainPage(provider.driver);
            mainpage.CloseAd();
            mainpage.ClickElementsButton();
            Assert.That(provider.driver.Url == "https://demoqa.com/elements");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageFormsTest()
        {

            MainPage mainpage = new MainPage(provider.driver);
            mainpage.CloseAd();
            mainpage.ClickFormsButton();
            Assert.That(provider.driver.Url == "https://demoqa.com/forms");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageAlertsFramesWindowsTest()
        {
            MainPage mainpage = new MainPage(provider.driver);
            mainpage.ClickAlertsFrameWindowsButton();
            Assert.That(provider.driver.Url == AlertsPage.URL);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageWidgetsTest()
        {
            MainPage mainpage = new MainPage(provider.driver);
            mainpage.ClickWidgetsButton();
            Assert.That(provider.driver.Url == "https://demoqa.com/widgets");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageInteractionsTest()
        {
            MainPage mainpage = new MainPage(provider.driver);
            mainpage.ClickInteractionsButton();
            Assert.That(provider.driver.Url == "https://demoqa.com/interaction");

        }


        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageBookStoreTest()
        {
            MainPage mainpage = new MainPage(provider.driver);
            mainpage.ClickBookStoreButton();
            Assert.That(provider.driver.Url == "https://demoqa.com/books");
        }





    }
}
