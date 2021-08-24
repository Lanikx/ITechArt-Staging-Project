using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Staging_project.Helpers;
using Staging_project.PageObjects;
using System;

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
            PageActing.CloseAd(provider.driver);
            alertsPage.PromptBoxButtonClick();
            PageActing.AlertExists(provider.driver);
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
            textBoxPage
                .EnterName("Cockpit Sergeevich")
                    .EnterEmail("ding@dong.com");
            PageActing.ScrollDown(provider.driver);
                        textBoxPage.PressSubmit();
            Assert.That(textBoxPage.GetOutputList()[0].Text + textBoxPage.GetOutputList()[1].Text == "Name:Cockpit SergeevichEmail:ding@dong.com");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void PracticeFormTest()
        {
            PracticeForm practiceForm = new PracticeForm(provider.driver);
            practiceForm.EnterName("Nikita")
                    .EnterLastName("Lapin")
                        .CheckGender(2)
                            .EnterNumber("0123456789")
                                .PressSubmit();
            Assert.That(PageActing.ElementExists(By.ClassName("modal-content"), provider.driver));  
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageElementsTest()
        {
            MainPage mainpage = new MainPage(provider.driver);
            PageActing.CloseAd(provider.driver);
            mainpage
                .ClickElementsButton();
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
            PageActing.CloseAd(provider.driver);
            mainpage
                .ClickFormsButton();
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
            mainpage
                .ClickAlertsFrameWindowsButton();
            Assert.That(provider.driver.Url == "https://demoqa.com/alertsWindows");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void MainPageWidgetsTest()
        {
            MainPage mainpage = new MainPage(provider.driver);
            mainpage
                .ClickWidgetsButton();
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
            mainpage
                .ClickInteractionsButton();
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
            mainpage
                .ClickBookStoreButton();
            Assert.That(provider.driver.Url == "https://demoqa.com/books");
        }





    }
}
