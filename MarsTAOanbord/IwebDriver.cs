using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MarsTAOanbord
{
    internal class IwebDriver
    {
        public static implicit operator IwebDriver(ChromeDriver v)
        {
            throw new NotImplementedException();
        }

        internal object Manage()
        {
            throw new NotImplementedException();
        }

        internal object Navigate()
        {
            throw new NotImplementedException();
        }

        internal IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }
    }
}