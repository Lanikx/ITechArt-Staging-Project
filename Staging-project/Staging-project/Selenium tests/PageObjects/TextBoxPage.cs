using OpenQA.Selenium;
using System.Collections.Generic;

namespace Staging_project.PageObjects
{
    class TextBoxPage : BasePage
    {       

        IWebElement nameField;

        IWebElement emailField;

        IWebElement currentAddressField;

        IWebElement permanentAddressField;

        IWebElement submitButton;

        private readonly string outputXPath = "//div/p[@id = 'name']|//div/p[@id = 'email']";

        public TextBoxPage(IWebDriver driver) : base(driver, "https://demoqa.com/text-box")
        {

        }


        public TextBoxPage EnterName(string name)
        {
            nameField = driver.FindElement(By.XPath("//div/input[@id = 'userName']"));
            if (IsOnPage("https://demoqa.com/text-box"))
            nameField.SendKeys(name);
            return this;
        }

        public TextBoxPage EnterEmail(string email)
        {
            emailField = driver.FindElement(By.XPath("//div/input[@id = 'userEmail']"));
            emailField.SendKeys(email);
            return this;
        }

        public TextBoxPage EnterCurrentAddress(string currentAddress)
        {
            currentAddressField = driver.FindElement(By.XPath("//div/textarea[@id = 'currentAddress']"));
            currentAddressField.SendKeys(currentAddress);
            return this;
        }

        public TextBoxPage EnterPermanentAddress(string permanentAddress)
        {
            permanentAddressField = driver.FindElement(By.XPath("//div/textarea[@id = 'permanentAddress']"));
            permanentAddressField.SendKeys(permanentAddress);
            return this;
        }

        public TextBoxPage PressSubmit()
        {
            submitButton = driver.FindElement(By.XPath("//div/button[@id = 'submit']"));
            submitButton.Click();
            return this;
        }

        public List<IWebElement> GetOutputList()
        {
            List<IWebElement> list = new List<IWebElement>();
            list.AddRange(driver.FindElements(By.XPath(outputXPath)));
            return list;
        }





    }
}
