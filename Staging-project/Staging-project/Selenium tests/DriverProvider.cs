using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Staging_project.PageObjects;
using System.Threading;

namespace Staging_project.Selenium_tests.Steps
{
    public class DriverProvider
    {

        private static ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

        public IWebDriver GetDriver()
        {
            if (_storedDriver.Value == null)
            {
                ChromeOptions options = new ChromeOptions();
                //options.addArguments("--headless");
                //options.addArguments("disable-gpu");
                _storedDriver.Value = new ChromeDriver(@"D:\PracticeTasks\ITechArt-Staging-Project\Staging-project\Staging-project\", options);
                _storedDriver.Value.Url = MainPage.URL;
            }
            return _storedDriver.Value;
        }

        public void Quit()
        {
            _storedDriver.Value.Quit();
        }
    }
}