using System;
using System.Collections.Generic;
using System.Text;
using dotnetcoreselenium.driver;
using OpenQA.Selenium;

namespace coretest.pageobjects.OrangeHrm
{
    public class LoginPage
    {
        private IWebDriver driver = WebDriver.Instance;

        private IWebElement LoginBtn => driver.FindElement(By.Id("btnLogin"));

        public  void GoToMainPage()
        {
            driver.Navigate().GoToUrl("https://orangehrm-demo-6x.orangehrmlive.com");

            driver.FindElement(By.Name("txtUsername")).Clear();
            IWebElement element = driver.FindElement(By.Name("txtUsername"));
            element.SendKeys("linda");
            driver.FindElement(By.Name("txtPassword")).Clear();
            IWebElement element1 = driver.FindElement(By.Name("txtPassword"));
            element1.SendKeys("linda.anderson");
          


        }

        public void LoginWithDefaultCredentions()
        {
            LoginBtn.Click();
        }
    }
}
