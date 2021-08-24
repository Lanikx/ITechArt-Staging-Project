using System;
using System.Collections.Generic;
using System.Text;

namespace Staging_project.Tests
{
    class RandomInputGenerator
    {

        public static string GenerateText(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";      
            StringBuilder builder = new StringBuilder();
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                builder.Append(chars[random.Next(chars.Length)]);
            }
            return builder.ToString();
        }

        public static string GenerateDigits(int length)
        {
            var chars = "0123456789";
            StringBuilder builder = new StringBuilder();
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                builder.Append(chars[random.Next(chars.Length)]);
            }
            return builder.ToString();
        }
    }
}
