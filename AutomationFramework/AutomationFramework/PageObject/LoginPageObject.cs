using AutomationFramework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObject
{
    
    public class LoginPageObject
    {
        private  IWebDriver driver = WebDriver.Instance;
       
        public IWebElement logIn => driver.FindElement(By.Name("login"));

        public void LoginWeb()
        {
            driver.Navigate().GoToUrl("http://www.store.demoqa.com");
            driver.FindElement(By.Name("username")).Clear();
            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("MareTest");
            driver.FindElement(By.Name("password")).Clear();
            IWebElement element1= driver.FindElement(By.Name("password"));
            element1.SendKeys("Mare.Tester");
            
        }
        public void LoginWithCredentions()
        {
            logIn.Click();
        }

       
    }
}
