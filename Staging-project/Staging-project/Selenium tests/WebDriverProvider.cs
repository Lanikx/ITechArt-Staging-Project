using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
                return _storedDriver.Value;
            }
        }

        public void Start()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("disable-gpu");
            _storedDriver.Value = new ChromeDriver(@"./", options);
        }


        public void Quit()
        {
            driver.Quit();
        }
    }
}
