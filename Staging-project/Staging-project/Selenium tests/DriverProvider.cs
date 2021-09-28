using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Staging_project.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class DriverProvider
    {
        private IWebDriver driver;

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                ChromeOptions options = new ChromeOptions();
                //options.addArguments("--headless");
                //options.addArguments("disable-gpu");
                driver = new ChromeDriver(options);
                driver.Url = MainPage.URL;
            }
            return driver;
        }

        public void Quit()
        {
            driver.Quit();
        }
    }
}