using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Staging_project.PageObjects
{
    class PracticeForm : BasePage
    {
        public const string URL = "https://demoqa.com/automation-practice-form";

        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement firstNameField;
        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement lastNameField;
        [FindsBy(How = How.XPath, Using = ".//input[@id = 'userNumber']")]
        private IWebElement numberField;
        [FindsBy(How = How.XPath, Using = ".//div/button[@id = 'submit']")]
        private IWebElement submitButton;
        [FindsBy(How = How.XPath, Using = ".//label[@for = 'gender-radio-0']")]
        private IWebElement maleGenderCheck;
        [FindsBy(How = How.XPath, Using = ".//label[@for = 'gender-radio-1']")]
        private IWebElement femaleGenderCheck;
        [FindsBy(How = How.XPath, Using = ".//label[@for = 'gender-radio-2']")]
        private IWebElement otherGenderCheck;
        [FindsBy(How = How.ClassName, Using = "modal-content")]
        private IWebElement modalContent;

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
