using NUnit.Framework;
using Staging_project.PageObjects;
using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtTextBoxPage
    {
        TextBoxPage textBoxPage;

        internal void SubmitData(string v1, string v2)
        {
            textBoxPage.EnterName(v1);
            textBoxPage.EnterEmail(v2);
        }

        internal void AssertOutput()
        {
           // Assert.That(textBoxPage.GetNameOutput() + textBoxPage.GetEmailOutput() == "Name:Cockpit SergeevichEmail:ding@dong.com");
        }
    }
}