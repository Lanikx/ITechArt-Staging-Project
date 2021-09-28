using NUnit.Framework;
using Staging_project.PageObjects;
using Staging_project.Selenium_tests.Helpers;
using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class AtPracticeFormPage
    {
        PracticeFormPage atPage;
        

        public AtPracticeFormPage(PracticeFormPage page)
        {
            this.atPage = page;
        }

        internal void EnterData(string name, string lastName, Gender gender, string number)
        {
            
            atPage.EnterName(name);
            atPage.EnterLastName(lastName);
            switch (gender)
            {
                case Gender.Female: atPage.CheckFemaleGender(); break;
                case Gender.Male: atPage.CheckMaleGender(); break;
                case Gender.Other: atPage.CheckOtherGender(); break;
            }
            atPage.EnterNumber(number);
            atPage.ScrollPageDown();
            atPage.PressSubmit();
        }

        internal void AssertModalContentExists()
        {
            Assert.That(atPage.ModalContentExists());
        }

        internal void AssertSomethingIsInvalid()
        {
            Assert.That(atPage.IsSomethingInvalid());
        }
    }
}