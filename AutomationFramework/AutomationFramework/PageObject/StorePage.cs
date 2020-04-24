using AutomationFramework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObject
{
    public class StorePage
    {

        private readonly IWebDriver driver = WebDriver.Instance;

        public void OpenStore()
        {
            driver.Navigate().GoToUrl("http://www.store.demoqa.com");
        }
        public void Close()
        {
            driver.Close();
        }

    }
}
