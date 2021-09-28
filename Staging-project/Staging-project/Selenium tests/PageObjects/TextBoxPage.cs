using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Staging_project.Selenium_tests.PageObjects;

namespace Staging_project.PageObjects
{
    public class TextBoxPage : ElementsPageGroup
    {

        public const string URL = "https://demoqa.com/text-box";

        private IWebElement nameField
        {
            get
            {
                return driver.FindElement(By.Id("userName"));
            }
        }

        private IWebElement emailField
        {
            get
            {
                return driver.FindElement(By.Id("userEmail"));
            }
        }

        private IWebElement currentAddressField
        {
            get
            {
                return driver.FindElement(By.XPath("//div/textarea[id() = 'currentAddress']"));
            }
        }

        private IWebElement permanentAddressField
        {
            get
            {
                return driver.FindElement(By.XPath("//div/textarea[id() = 'permanentAddress']"));
            }
        }

        private IWebElement submitButton
        {
            get
            {
                return driver.FindElement(By.XPath("//div/button[@id = 'submit']"));
            }
        }

        private IWebElement outputEmail
        {
            get
            {
                return driver.FindElement(By.XPath("//div/p[@id = 'email']"));
            }
        }

        private IWebElement outputName
        {
            get
            {
                return driver.FindElement(By.XPath("//div/p[@id = 'name']"));
            }
        }


        public TextBoxPage(IWebDriver driver) : base(driver)
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

        public void ClickSubmit()
        {
            submitButton.Click();
        }

        public string GetNameOutput()
        {
            return outputName.Text;
        }

        public string GetEmailOutput()
        {
            return outputEmail.Text; 
        }







    }
}
