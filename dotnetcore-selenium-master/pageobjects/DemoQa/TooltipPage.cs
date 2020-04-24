using System;
using dotnetcoreselenium.driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace coretest.pageobjects.DemoQa
{
    class TooltipPage
    {
        private IWebDriver driver = WebDriver.Instance;

        private IWebElement AgeField => driver.FindElement(By.Id("age"));

        public void PrintAgeTip()
        {
            var actions = new Actions(driver);
            actions.MoveToElement(AgeField);
            Console.WriteLine(AgeField.GetAttribute("title"));
        }
    }
}
