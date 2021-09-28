using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Staging_project.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Staging_project.Tests
{
    public class WebDriverProvider
    {
        private static ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

        public IWebDriver driver
        {
            get
            {
                if (driver == null)
                {
                    ChromeOptions options = new ChromeOptions();
                    //options.addArguments("--headless");
                    //options.addArguments("disable-gpu");
                    _storedDriver.Value = new ChromeDriver(@"D:\PracticeTasks\ITechArt-Staging-Project\Staging-project\Staging-project\", options);
                    _storedDriver.Value.Url = MainPage.URL;
                }               
                return _storedDriver.Value;
            }

            set { driver = value; }
        }

        public IWebDriver Start()
        {
            return driver;
        }


        public void Quit()
        {
            driver.Quit();
        }

    }
}
