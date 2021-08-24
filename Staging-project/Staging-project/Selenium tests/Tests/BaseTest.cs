using NUnit.Framework;
using Staging_project.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Staging_project.Tests
{
    class BaseTest
    {

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
            data = XMLRead.ReadFile(@"E:\itech\ITechArt-Staging-Project\Staging-project\Staging-project\Selenium tests\Tests\InputData.xml");
        }
    }
}
