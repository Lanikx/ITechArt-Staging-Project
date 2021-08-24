using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Staging_project.Helpers
{
    class InvalidCheck
    {
        internal static bool IsSomethingInvalid(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".form-control.is-invalid, .was-validated .form-control:invalid"))) != null;
        }


    }
}
