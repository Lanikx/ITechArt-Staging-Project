using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Staging_project.PageObjects
{
    class PracticeForm : BasePage
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
                return driver.FindElement(By.XPath(".//label[@for = 'gender-radio-0']"));
            }
        }

        private IWebElement femaleGenderCheck
        {
            get
            {
                return driver.FindElement(By.XPath(".//label[@for = 'gender-radio-1']"));
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

        public PracticeForm(IWebDriver driver) : base(driver, URL)
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
