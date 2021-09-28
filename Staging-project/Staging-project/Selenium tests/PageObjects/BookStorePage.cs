using OpenQA.Selenium;
using Staging_project.PageObjects;
using Staging_project.Selenium_tests.PageObjects;

namespace Staging_project.Selenium_tests.Steps
{
    public class BookStorePage : BookStoreApplicationPageGroup
    {
        public static string URL = "https://demoqa.com/books";


        public BookStorePage(IWebDriver driver) : base(driver)
        {
        }

    }
}