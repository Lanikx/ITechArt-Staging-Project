using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.PageObjects
{
    class MainPage : BasePage
    {

        public MainPage(IWebDriver driver) : base(driver, "https://demoqa.com/")
        {

        }


        
        public void ClickElementsButton()
        {
            if (IsOnPage("https://demoqa.com/"))
                driver.FindElements(By.XPath("//div[@class = 'category-cards']/div"))[0].Click(); 
        }


        public void ClickFormsButton()
        {
            if (IsOnPage("https://demoqa.com/"))
                driver.FindElements(By.XPath("//div[@class = 'category-cards']/div"))[1].Click();
        }

        public void ClickAlertsFrameWindowsButton()
        {
            if (IsOnPage("https://demoqa.com/"))
                driver.FindElements(By.XPath("//div[@class = 'category-cards']/div"))[2].Click();
        }

        public void ClickWidgetsButton()
        {
            if (IsOnPage("https://demoqa.com/"))
                driver.FindElements(By.XPath("//div[@class = 'category-cards']/div"))[3].Click();
        }

        public void ClickInteractionsButton()
        {
            if (IsOnPage("https://demoqa.com/"))
                driver.FindElements(By.XPath("//div[@class = 'category-cards']/div"))[4].Click();
        }

        public void ClickBookStoreButton()
        {
            if (IsOnPage("https://demoqa.com/"))
            driver.FindElements(By.XPath("//div[@class = 'category-cards']/div"))[5].Click();
        }


    }
}
