using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Support.UI;
    

namespace seleniumDemo
{
    [TestClass]
    public class UnitTest1
    {

        static IWebDriver driverGC;

        public object ExpectedConditions { get; private set; }

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            //string path = Directory.GetCurrentDirectory();
            //driverGC = new ChromeDriver(@path);
        }

        [TestMethod]
        public void OpenCreateCarScreen()
        {
            driverGC = new ChromeDriver(Directory.GetCurrentDirectory());
            driverGC.Navigate().GoToUrl("http://localhost:8081/");
            driverGC.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driverGC.FindElement(By.XPath("//*[@href='#/CAR']")).Click();
            Thread.Sleep(2000);
            driverGC.Quit();
        }

        [TestMethod]
        public void CreateCarPackageScreen()
        {

            driverGC = new ChromeDriver(Directory.GetCurrentDirectory());
            driverGC.Navigate().GoToUrl("http://localhost:8081/");
            driverGC.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driverGC.FindElement(By.XPath("//*[@href='#/CAR']")).Click();
            Thread.Sleep(7000);

            IWebElement borrower = driverGC.FindElement(By.Name("borrowerdropdown"));
            SelectElement borrowerSelect = new SelectElement(borrower);
            borrowerSelect.SelectByIndex(6);
            Thread.Sleep(6000);

            IWebElement team = driverGC.FindElement(By.Name("dropdownTeam"));
            SelectElement teamSelect = new SelectElement(team);
            teamSelect.SelectByIndex(1);
            Thread.Sleep(2000);

            IWebElement srm = driverGC.FindElement(By.Name("dropdownteamleader"));
            SelectElement srmSelect = new SelectElement(srm);
            srmSelect.SelectByIndex(1);
            Thread.Sleep(2000);

            IWebElement analyst = driverGC.FindElement(By.Name("dropdownanalyst"));
            SelectElement analystSelect = new SelectElement(analyst);
            analystSelect.SelectByIndex(2);
            Thread.Sleep(2000);

            IWebElement rm = driverGC.FindElement(By.Name("dropdownRM"));
            SelectElement rmSelect = new SelectElement(rm);
            rmSelect.SelectByIndex(2);
            Thread.Sleep(2000);

            IWebElement sco = driverGC.FindElement(By.Name("dropdownSCO"));
            SelectElement scoSelect = new SelectElement(sco);
            scoSelect.SelectByIndex(1);
            Thread.Sleep(2000);
            driverGC.FindElement(By.XPath("//*[@href='/']")).Click();

            Thread.Sleep(2000);

            driverGC.Quit();

        }
    }
}
