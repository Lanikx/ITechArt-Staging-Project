using OpenQA.Selenium;
using Staging_project.PageObjects;
using Staging_project.Selenium_tests.PageObjects;
using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class ElementsPage : ElementsPageGroup
    {
        public string URL = "https://demoqa.com/elements";



        public ElementsPage(IWebDriver driver) : base (driver)
        {

        }

        
    }
}