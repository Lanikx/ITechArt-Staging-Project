using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using Staging_project.PageObjects;

namespace Staging_project.Tests.Negative
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    [AllureNUnit]
    class HotTests : BaseTest
    {


        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void RegistrationFormNoInputTest()
        {
            user.atMainPage.GoToElementsPage();
            user.atElementsPage.GoToWebTablesPage();
            user.atWebTablesPage.Add();
            user.atWebTablesPage.AssertAddFailed();
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void LoginPageNoInputTest()
        {
            user.atMainPage.
            LoginPage loginPage = new LoginPage(provider.driver);
            loginPage.CloseAd();
            loginPage.PressLogin();
            Assert.That(loginPage.IsSomethingInvalid);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void StudentRegistrationNoInputTest()
        {
            PracticeForm practiceForm = new PracticeForm(provider.driver);
            practiceForm.PressSubmit();
            Assert.That(practiceForm.IsSomethingInvalid());
        }

        //[Test]
        //[AllureTag("Regression")]
        //[AllureSeverity(SeverityLevel.critical)]
        //[AllureIssue("ISSUE-1")]
        //[AllureOwner("Nikita Lapin")]
        //public void StudentRegistrationNameInputTest()
        //{
        //    PracticeForm practiceForm = new PracticeForm(provider.driver);
        //    practiceForm
        //        .EnterData(RandomInputGenerator.GenerateText(8), "", "");
        //    practiceForm.PressSubmit();
        //    Assert.That(practiceForm.IsSomethingInvalid());
        //}

        //[Test]
        //[AllureTag("Regression")]
        //[AllureSeverity(SeverityLevel.critical)]
        //[AllureIssue("ISSUE-1")]
        //[AllureOwner("Nikita Lapin")]
        //public void StudentRegistrationInputLastNameTest()
        //{
        //    PracticeForm practiceForm = new PracticeForm(provider.driver);
        //    practiceForm
        //        .EnterData("", RandomInputGenerator.GenerateText(8), "");
        //    practiceForm.PressSubmit();
        //    Assert.That(practiceForm.IsSomethingInvalid());
        //}

        //[Test]
        //[AllureTag("Regression")]
        //[AllureSeverity(SeverityLevel.critical)]
        //[AllureIssue("ISSUE-1")]
        //[AllureOwner("Nikita Lapin")]
        //public void StudentRegistrationInputTest()
        //{
        //    PracticeForm practiceForm = new PracticeForm(provider.driver);
        //    practiceForm
        //        .EnterData("", "", RandomInputGenerator.GenerateDigits(8));
        //    practiceForm.PressSubmit();
        //    Assert.That(practiceForm.IsSomethingInvalid());
        //}



    }
}
