using NUnit.Framework;
using Staging_project.PageObjects;
using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtTextBoxPage
    {
        private TextBoxPage atPage;
        

        public AtTextBoxPage(TextBoxPage page)
        {
            this.atPage = page;
        }

        internal void SubmitData(string name, string email)
        {
            atPage.EnterName(name);
            atPage.EnterEmail(email);
            atPage.ClickSubmit();
        }

        internal void AssertOutput(string expectedOutput)
        {
            var output = atPage.GetNameOutput() + atPage.GetEmailOutput();
           Assert.That(output == expectedOutput);
        }
    }
}