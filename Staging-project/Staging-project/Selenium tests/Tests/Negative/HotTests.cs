using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using Staging_project.Helpers;
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
            WebTables webTables = new WebTables(provider.driver);

            webTables.PressAddButton()
                        .PressSubmitButton();
            bool somethingInvalidExists = InvalidCheck.IsSomethingInvalid(provider.driver);

            Assert.That(somethingInvalidExists);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void LoginPageNoInputTest()
        {
            LoginPage loginPage = new LoginPage(provider.driver);
            PageActing.CloseAd(provider.driver);
            loginPage
                .Login("", "")
                .PressLogin();
            var somethingIsInvalid = InvalidCheck.IsSomethingInvalid(provider.driver);
            Assert.That(somethingIsInvalid);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void StudentRegistrationNoInputTest()
        {
            PracticeForm practiceForm = new PracticeForm(provider.driver);
            practiceForm
                .EnterData("", "", "");
            practiceForm.PressSubmit();
            Assert.That(practiceForm.IsSomethingInvalid());
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void StudentRegistrationNameInputTest()
        {
            PracticeForm practiceForm = new PracticeForm(provider.driver);
            practiceForm
                .EnterData(RandomInputGenerator.GenerateText(8), "", "");
            practiceForm.PressSubmit();
            Assert.That(practiceForm.IsSomethingInvalid());
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void StudentRegistrationInputLastNameTest()
        {
            PracticeForm practiceForm = new PracticeForm(provider.driver);
            practiceForm
                .EnterData("", RandomInputGenerator.GenerateText(8), "");
            practiceForm.PressSubmit();
            Assert.That(practiceForm.IsSomethingInvalid());
        }

        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureOwner("Nikita Lapin")]
        public void StudentRegistrationInputTest()
        {
            PracticeForm practiceForm = new PracticeForm(provider.driver);
            practiceForm
                .EnterData("", "", RandomInputGenerator.GenerateDigits(8));
            practiceForm.PressSubmit();
            Assert.That(practiceForm.IsSomethingInvalid());
        }



    }
}
