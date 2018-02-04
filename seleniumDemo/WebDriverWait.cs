using System;
using OpenQA.Selenium;

namespace seleniumDemo
{
    internal class WebDriverWait
    {
        private IWebDriver driverGC;
        private object p;

        public WebDriverWait(IWebDriver driverGC, object p)
        {
            this.driverGC = driverGC;
            this.p = p;
        }

        internal void Until(object p)
        {
            throw new NotImplementedException();
        }
    }
}