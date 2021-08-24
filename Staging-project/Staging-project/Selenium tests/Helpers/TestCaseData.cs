using Staging_project.Tests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.Helpers
{
    class TestCaseData
    {
        public static object[] StudentRegistrationInput = {
                new object[] { "", "", RandomInputGenerator.GenerateDigits(8) },
                new object[] { "", RandomInputGenerator.GenerateText(8), "" },
                new object[] { RandomInputGenerator.GenerateText(8), "", "" }
            };
    }
}
