using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Staging_project.Selenium_tests.PageObjects;
using Staging_project.Selenium_tests.Steps;

namespace Staging_project.PageObjects
{
    public class PracticeFormPage : FormsPageGroup
    {
        public const string URL = "https://demoqa.com/automation-practice-form";


        private IWebElement firstNameField
        {
            get
            {
                return driver.FindElement(By.Id("firstName"));
            }
        }

        private IWebElement lastNameField
        {
            get
            {
                return driver.FindElement(By.Id("lastName"));
            }
        }

        private IWebElement numberField
        {
            get
            {
                return driver.FindElement(By.XPath(".//input[@id = 'userNumber']"));
            }
        }

        private IWebElement submitButton
        {
            get
            {
                return driver.FindElement(By.XPath(".//div/button[@id = 'submit']"));
            }
        }

        private IWebElement maleGenderCheck
        {
            get
            {
                return driver.FindElement(By.XPath(".//label[@for = 'gender-radio-2']"));
            }
        }

        private IWebElement femaleGenderCheck
        {
            get
            {
                return driver.FindElement(By.XPath(".//label[@for = 'gender-radio-3']"));
            }
        }

        private IWebElement otherGenderCheck
        {
            get
            {
                return driver.FindElement(By.XPath(".//label[@for = 'gender-radio-2']"));
            }
        }

        private IWebElement modalContent
        {
            get
            {
                return driver.FindElement(By.ClassName("modal-content"));
            }
        }

        public PracticeFormPage(IWebDriver driver) : base(driver)
        {
            
        }


        public bool ModalContentExists()
        {
            return modalContent != null;
        }


        public void EnterName(string name)
        {
            firstNameField.SendKeys(name);
        }

        public void EnterLastName(string lastName)
        {
            lastNameField.SendKeys(lastName);
        }

        public void CheckMaleGender() 
        {
            maleGenderCheck.Click();
        }

        public void CheckFemaleGender() 
        {
            femaleGenderCheck.Click();
        }

        public void CheckOtherGender() 
        {
            otherGenderCheck.Click();
        }


        public void EnterNumber(string number)
        {
            numberField.SendKeys(number);
        }


        internal void PressSubmit()
        {
            submitButton.Click();
        }

    }
}
