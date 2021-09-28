using NUnit.Framework;
using Staging_project.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using Staging_project.Selenium_tests.Steps;

namespace Staging_project.Tests
{
    class BaseTest
    {
        protected User user;

        protected object[] data;

        [SetUp]
        public void AhShitHereWeGoAgain()
        {
            user = new User(new PageProvider());
        }

        [TearDown]
        public void YouHadToFollowTheDamnTrainCJ()
        {
            user.pageProvider.Quit();
        }

        [OneTimeSetUp]
        public void AndHereItGoes()
        {
            
           
        }
    }
}
