using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Staging_project.PageObjects
{
    class TextBoxPage : BasePage
    {

        public const string URL = "https://demoqa.com/text-box";

        [FindsBy(How = How.XPath, Using = "//div/input[@id = 'userName']")]
        private IWebElement nameField;
        [FindsBy(How = How.XPath, Using = "//div/input[@id = 'userEmail']")]
        private IWebElement emailField;
        [FindsBy(How = How.XPath, Using = "//div/textarea[@id = 'currentAddress']")]
        private IWebElement currentAddressField;
        [FindsBy(How = How.XPath, Using = "//div/textarea[@id = 'permanentAddress']")]
        private IWebElement permanentAddressField;
        [FindsBy(How = How.XPath, Using = "//div/button[@id = 'submit']")]
        private IWebElement submitButton;
        [FindsBy(How = How.XPath, Using = "//div/p[@id = 'email']")]
        private IWebElement outputEmail;
        [FindsBy(How = How.XPath, Using = "//div/p[@id = 'name']")]
        private IWebElement outputName;


        public TextBoxPage(IWebDriver driver) : base(driver, URL)
        {

        }


        public void EnterName(string name)
        {
            nameField.SendKeys(name);
        }

        public void EnterEmail(string email)
        {
            emailField.SendKeys(email);
        }

        public void EnterCurrentAddress(string currentAddress)
        {
            currentAddressField.SendKeys(currentAddress);
        }

        public void EnterPermanentAddress(string permanentAddress)
        {
            permanentAddressField.SendKeys(permanentAddress);
        }

        public void PressSubmit()
        {
            submitButton.Click();
        }

        public string GetNameOutput()
        {
            return outputEmail.Text;
        }
        
        public string GetEmailOutput()
        {
            return outputName.Text;
        }

       





    }
}
