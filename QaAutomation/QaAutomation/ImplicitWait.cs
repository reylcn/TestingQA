using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAutomation
{
    [TestClass]
    public class ImplicitWait
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void Implicit()
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(500);
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-switch-windows-2/");
            IWebElement element = driver.FindElement(By.Id("target"));
            driver.Close();
        }
        
    }
}
