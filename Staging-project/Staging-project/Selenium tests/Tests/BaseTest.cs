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

        protected WebDriverProvider provider = new WebDriverProvider();

        protected object[] data;

        [SetUp]
        public void AhShitHereWeGoAgain()
        {
            provider.Start();
        }

        [TearDown]
        public void YouHadToFollowTheDamnTrainCJ()
        {
            provider.Quit();
        }

        [OneTimeSetUp]
        public void AndHereItGoes()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
           
        }
    }
}
