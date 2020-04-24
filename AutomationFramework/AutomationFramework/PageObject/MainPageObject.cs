using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObject
{
    public class MainPageObject
    {

        private readonly IWebDriver driver;

        public IWebElement dissMiss => driver.FindElement(By.LinkText("Dismiss"));
        
        public IWebElement accoUnt => driver.FindElement(By.LinkText("My Account"));

        public void Dismiss()
        {
            dissMiss.Click();
        }
        public void Account()
        {
            accoUnt.Click();
        }
    }
}
