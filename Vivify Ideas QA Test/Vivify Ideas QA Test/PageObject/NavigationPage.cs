using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Vivify_Ideas_QA_Test.Driver;

namespace Vivify_Ideas_QA_Test.PageObject
{
    public class NavigationPage
    {

        private IWebDriver driver = WebDriver.Instance;

        public void NavigateToHomePage()
        {
            driver.Navigate().GoToUrl("https://gallery-app.vivifyideas.com/");
        }
    }
}
