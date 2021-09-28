using NUnit.Framework;
using OpenQA.Selenium;
using Staging_project.PageObjects;
using System;

namespace Staging_project.Selenium_tests.Steps
{
    public class PageProvider
    {
        DriverProvider provider;


        public void Quit()
        {
            provider.Quit();
        }

        public IWebDriver setDriver()
        {
            if (provider == null)
            {
                provider = new DriverProvider();
            }
            return provider.GetDriver();
        }


        public T InitPage<T>() 
        {
            object[] param = { setDriver() };
           return (T)Activator.CreateInstance(typeof(T), param);
        }
}
}