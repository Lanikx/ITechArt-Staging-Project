using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Staging_project.Helpers;
using System;

namespace Staging_project.PageObjects
{
    class PracticeForm : BasePage
    {

        IWebElement firstNameField;

        IWebElement lastNameField;

        IWebElement numberField;

        IWebElement submitButton;

        public PracticeForm(IWebDriver driver) : base(driver, "https://demoqa.com/automation-practice-form")
        {

        }





        public PracticeForm EnterName(string name)
        {
            firstNameField = driver.FindElement(By.Id("firstName"));
            if (IsAtPage())
            {
                firstNameField.SendKeys(name);
            }

            return this;
        }

        public PracticeForm EnterLastName(string lastName)
        {
            lastNameField = driver.FindElement(By.Id("lastName"));
            if (IsAtPage())
            {
                lastNameField.SendKeys(lastName);
            }

            return this;
        }

        public PracticeForm CheckGender(int checkId)
        {
            if (IsAtPage())
            {
                driver.FindElement(By.XPath(".//label[@for = 'gender-radio-" + checkId + "']")).Click();
            }

            return this;
        }

        public PracticeForm EnterNumber(string number)
        {
            numberField = driver.FindElement(By.XPath(".//input[@id = 'userNumber']"));
            if (IsAtPage())
            {
                numberField.SendKeys(number);
            }

            return this;
        }

        internal bool IsSomethingInvalid()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".form-control.is-invalid, .was-validated .form-control:invalid"))) != null;
        }

        private bool IsAtPage()
        {
            if (driver.Url == "https://demoqa.com/automation-practice-form")
            {
                return true;
            }

            return false;
        }

        public void EnterData(string name, string lastName, int gender, string number)
        {
            EnterName(name);
            EnterLastName(lastName);
            CheckGender(gender);
            EnterNumber(number);
        }

        public void EnterData(string name, string lastName, string number)
        {
            EnterName(name);
            EnterLastName(lastName);
            EnterNumber(number);
        }

        internal void PressSubmit()
        {submitButton = driver.FindElement(By.XPath(".//div/button[@id = 'submit']"));
            PageActing.ScrollDown(driver);
            submitButton.Click();

        }
       
    }
}
