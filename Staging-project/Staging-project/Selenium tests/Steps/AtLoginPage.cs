using NUnit.Framework;
using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtLoginPage
    {
        LoginPage loginPage;

        public AtLoginPage(LoginPage loginPage)
        {
            this.loginPage = loginPage;
        }


        public void Login(string login, string password)
        {
            loginPage.EnterPassword(password);
            loginPage.EnterUserName(login);
            loginPage.PressLoginButton();

        }


        public void assertLoginFailed()
        {
            Assert.That( loginPage.FailedFieldExists());
        }
    }
}